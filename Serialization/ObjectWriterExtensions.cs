﻿#region License
// Copyright (c) 2014, David Taylor
//
// Permission to use, copy, modify, and/or distribute this software for any 
// purpose with or without fee is hereby granted, provided that the above 
// copyright notice and this permission notice appear in all copies, unless 
// such copies are solely in the form of machine-executable object code 
// generated by a source language processor.
//
// THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES 
// WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF 
// MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR 
// ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES 
// WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN 
// ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF 
// OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
#endregion License
using System;
using System.Collections;
using System.Collections.Generic;

namespace HotChai.Serialization
{
    public static class ObjectWriterExtensions
    {
        #region Member writers

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            bool value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            int value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            uint value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            long value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            ulong value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            float value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            double value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            byte[] value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            string value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        #endregion Member writers

        #region Member array writers

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<bool> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<int> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<uint> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<long> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<ulong> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<float> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<double> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<string> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        #endregion Member array writers

        #region Array value writers

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<bool> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<int> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<uint> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<long> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<ulong> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<float> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<double> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<string> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        #endregion Array value writers

        #region Extended types

        public static void WriteValue(
            this IObjectWriter writer,
            Guid value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteValue(value.ToByteArray());
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            Guid value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<Guid> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<Guid> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteValue(
            this IObjectWriter writer,
            TimeSpan value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteValue(value.Ticks);
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            TimeSpan value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<TimeSpan> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<TimeSpan> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteValue(
            this IObjectWriter writer,
            DateTime value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (value.Kind != DateTimeKind.Utc)
            {
                throw new NotSupportedException("DateTime must be converted to UTC before serializing.");
            }

            writer.WriteValue(value.Ticks);
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            DateTime value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<DateTime> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<DateTime> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        public static void WriteValue(
            this IObjectWriter writer,
            DateTimeOffset value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (value.Offset != TimeSpan.Zero)
            {
                throw new NotSupportedException("DateTimeOffset must be converted to UTC before serializing.");
            }

            writer.WriteValue(value.UtcTicks);
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            DateTimeOffset value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteValue(value);
            writer.WriteEndMember();
        }

        public static void WriteMember(
            this IObjectWriter writer,
            int key,
            IEnumerable<DateTimeOffset> value)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            writer.WriteStartMember(key);
            writer.WriteArray(value);
            writer.WriteEndMember();
        }

        public static void WriteArray(
            this IObjectWriter writer,
            IEnumerable<DateTimeOffset> array)
        {
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            if (array == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();

            foreach (var value in array)
            {
                writer.WriteValue(value);
            }

            writer.WriteEndArray();
        }

        #endregion Extended types
    }
}
