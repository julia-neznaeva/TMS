using AutotestApp.Common.Enums;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutotestApp.Common
{
    public class AssertsAccumulator
    {
        private StringBuilder Errors { get; set; }
        public Dictionary<String, String> Info { get; set; }
        private Boolean AssertsPassed { get; set; }
        public MemoryStream FileData { get; set; }

        private String AccumulatedErrorMessage => Errors.ToString();

        public AssertsAccumulator()
        {
            Clear();
        }

        private void ProcessException(Exception ex)
        {
            String errorMsg = ex.Message;

            RegisterError(errorMsg);
        }

        private void RegisterError(String errorMessage)
        {
            AssertsPassed = false;
            Errors.AppendLine(errorMessage);
        }

        public void Clear()
        {
            Errors = new StringBuilder();
            AssertsPassed = true;
            Info = new Dictionary<String, String>();
            FileData = null;
        }

        /// <summary>
        /// Use Accumulate method if you want to do one and more asserts in the test and do not stop test if assert(s) failed.
        /// </summary>
        /// <param name="assert"></param>
        public void Accumulate(Action assert)
        {
            try
            {
                assert.Invoke();
            }
            catch (Exception exception)
            {
                ProcessException(exception);
            }
        }

        /// <summary>
        /// Use Check method if you want to stop test in case, when this assert failed.
        /// </summary>
        /// <param name="assert"></param>
        public void Check(Action assert)
        {
            try
            {
                assert.Invoke();
            }
            catch (Exception exception)
            {
                ProcessException(exception);
                throw new Exception();
            }
        }

        public void Release()
        {
            if ((TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed && TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Skipped) || !AssertsPassed)
            {
                foreach (var key in Info.Keys)
                {
                    Errors.Insert(0, $"{key} : {Info[key]}{Environment.NewLine}{Environment.NewLine}");
                }

                if (FileData != null)
                {
                    Errors.AppendLine("----------FILE DATA----------\r\n");
                    using (MemoryStream stream = new MemoryStream(FileData.ToArray()))
                    {
                        StreamReader sr = new StreamReader(stream);
                        Errors.AppendLine(sr.ReadToEnd().Replace(">", "&gt;").Replace("<", "&lt;"));
                    }
                }

                throw new AssertionException(AccumulatedErrorMessage);
            }
        }
    }

    public static class AdditionalInfoExtension
    {
        public static void Add(this Dictionary<String, String> dict, LogKey key, String value)
        {
            dict.Add(key.ToString(), value);
        }
    }
}