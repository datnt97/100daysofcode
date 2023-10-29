using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{

	[TestClass]
	public class FileProcessTest
	{
		private const string BAD_FILE_NAME = @"C:\BadFileName.bad";

		public TestContext TestContext { get; set; }

		[TestMethod]
		public void FileNameDoesExist()
		{
			FileProcess fp = new();
			bool fromCall;

			TestContext.WriteLine("Checking File: @\"C:\\Windows\\Regedit.exe\"");

			fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

			Assert.IsTrue(fromCall);
		}

		[TestMethod]
		public void FileNameDoesNotExist()
		{
			FileProcess fp = new ();
			bool fromCall;

			fromCall = fp.FileExists(BAD_FILE_NAME);

			Assert.IsFalse(fromCall);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void FileNameNullOrEmpty_UsingAttribute()
		{
			FileProcess fp = new();

			_ = fp.FileExists("");
		}

		[TestMethod]
		public void FileNameNullOrEmpty_UsingTryCatch()
		{
			FileProcess fp = new();

			try
			{
				_ = fp.FileExists("");
			}
			catch (ArgumentNullException)
			{
				// Test was a success
				return;
			}

			// Fail the test
			Assert.Fail("Call to FileExists() did NOT throw an ArgumentNullException.");
		}
	}
}
