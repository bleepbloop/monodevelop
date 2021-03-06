// AddinReferenceNodeBuilder.cs
//
// Author:
//   Lluis Sanchez Gual <lluis@novell.com>
//
// Copyright (c) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//

using System;
using MonoDevelop.Projects;
using MonoDevelop.Core;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Ide.Gui.Pads;
using MonoDevelop.Ide.Gui.Pads.ProjectPad;
using MonoDevelop.Components.Commands;
using Mono.Addins;
using Mono.Addins.Description;
using MonoDevelop.Ide.Gui.Components;
using Gdk;

namespace MonoDevelop.AddinAuthoring
{
	public class AddinReferenceNodeBuilder: TypeNodeBuilder
	{
		public override Type NodeDataType {
			get { return typeof(AddinDependency); }
		}
		
		public override Type CommandHandlerType {
			get { return typeof(AddinReferenceCommandHandler); }
		}
		
		public override string ContextMenuAddinPath {
			get { return "/MonoDevelop/AddinAuthoring/ContextMenu/ProjectPad/AddinReference"; }
		}

		
		public override string GetNodeName (ITreeNavigator thisNode, object dataObject)
		{
			AddinDependency adep = (AddinDependency) dataObject;
			return Addin.GetIdName (adep.AddinId);
		}

		
		public override void BuildNode (ITreeBuilder treeBuilder, object dataObject, ref string label, ref Pixbuf icon, ref Pixbuf closedIcon)
		{
			AddinDependency adep = (AddinDependency) dataObject;
			label = Addin.GetIdName (adep.AddinId);
			icon = closedIcon = Context.GetIcon ("md-addin-reference");
		}
	}
	
	class AddinReferenceCommandHandler: NodeCommandHandler
	{
		public override void DeleteItem ()
		{
			DotNetProject p = CurrentNode.GetParentDataItem (typeof(Project), true) as DotNetProject;
			AddinData data = AddinData.GetAddinData (p);
			AddinDependency adep = (AddinDependency) CurrentNode.DataItem;
			
			string q = AddinManager.CurrentLocalizer.GetString ("Are you sure you want to remove the reference to add-in '{0}'?", Addin.GetIdName (adep.AddinId));
			if (MessageService.Confirm (q, AlertButton.Remove)) {
				AddinAuthoringService.RemoveReferences (data, new string[] { adep.FullAddinId });
			}
		}
	}
}
