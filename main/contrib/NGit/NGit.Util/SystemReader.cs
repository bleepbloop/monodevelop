/*
This code is derived from jgit (http://eclipse.org/jgit).
Copyright owners are documented in jgit's IP log.

This program and the accompanying materials are made available
under the terms of the Eclipse Distribution License v1.0 which
accompanies this distribution, is reproduced below, and is
available at http://www.eclipse.org/org/documents/edl-v10.php

All rights reserved.

Redistribution and use in source and binary forms, with or
without modification, are permitted provided that the following
conditions are met:

- Redistributions of source code must retain the above copyright
  notice, this list of conditions and the following disclaimer.

- Redistributions in binary form must reproduce the above
  copyright notice, this list of conditions and the following
  disclaimer in the documentation and/or other materials provided
  with the distribution.

- Neither the name of the Eclipse Foundation, Inc. nor the
  names of its contributors may be used to endorse or promote
  products derived from this software without specific prior
  written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND
CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES,
INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.Net;
using NGit.Storage.File;
using NGit.Util;
using Sharpen;

namespace NGit.Util
{
	/// <summary>Interface to read values from the system.</summary>
	/// <remarks>
	/// Interface to read values from the system.
	/// <p>
	/// When writing unit tests, extending this interface with a custom class
	/// permits to simulate an access to a system variable or property and
	/// permits to control the user's global configuration.
	/// </p>
	/// </remarks>
	public abstract class SystemReader
	{
		private sealed class _SystemReader_64 : SystemReader
		{
			public _SystemReader_64()
			{
			}

			private string hostname;

			public override string Getenv(string variable)
			{
				return Runtime.Getenv(variable);
			}

			public override string GetProperty(string key)
			{
				return Runtime.GetProperty(key);
			}

			public override FileBasedConfig OpenUserConfig(FS fs)
			{
				FilePath home = fs.UserHome();
				return new FileBasedConfig(new FilePath(home, ".gitconfig"), fs);
			}

			public override string GetHostname()
			{
				if (this.hostname == null)
				{
					try
					{
						IPAddress localMachine = Sharpen.Runtime.GetLocalHost();
						this.hostname = localMachine.ToString();
					}
					catch (UnknownHostException)
					{
						// we do nothing
						this.hostname = "localhost";
					}
				}
				return this.hostname;
			}

			public override long GetCurrentTime()
			{
				return Runtime.CurrentTimeMillis();
			}

			public override int GetTimezone(long when)
			{
				return System.TimeZoneInfo.Local.GetOffset(when) / (60 * 1000);
			}
		}

		private static SystemReader INSTANCE = new _SystemReader_64();

		/// <returns>the live instance to read system properties.</returns>
		public static SystemReader GetInstance()
		{
			return INSTANCE;
		}

		/// <param name="newReader">the new instance to use when accessing properties.</param>
		public static void SetInstance(SystemReader newReader)
		{
			INSTANCE = newReader;
		}

		/// <summary>Gets the hostname of the local host.</summary>
		/// <remarks>
		/// Gets the hostname of the local host. If no hostname can be found, the
		/// hostname is set to the default value "localhost".
		/// </remarks>
		/// <returns>the canonical hostname</returns>
		public abstract string GetHostname();

		/// <param name="variable">system variable to read</param>
		/// <returns>value of the system variable</returns>
		public abstract string Getenv(string variable);

		/// <param name="key">of the system property to read</param>
		/// <returns>value of the system property</returns>
		public abstract string GetProperty(string key);

		/// <param name="fs">
		/// the file system abstraction which will be necessary to
		/// perform certain file system operations.
		/// </param>
		/// <returns>the git configuration found in the user home</returns>
		public abstract FileBasedConfig OpenUserConfig(FS fs);

		/// <returns>the current system time</returns>
		public abstract long GetCurrentTime();

		/// <param name="when">TODO</param>
		/// <returns>the local time zone</returns>
		public abstract int GetTimezone(long when);
	}
}
