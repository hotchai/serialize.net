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
using System.IO;
using System.Text;

namespace HotChai.Serialization.PortableBinary
{
    public sealed class PortableBinaryObjectWriter : ObjectWriter
    {
        private InspectorStream _stream;
        private BinaryWriter _writer;

        public PortableBinaryObjectWriter(
            Stream stream)
        {
            if (null == stream)
            {
                throw new ArgumentNullException("stream");
            }

            this._stream = new InspectorStream(stream);
            this._writer = new BinaryWriter(this._stream);
        }

        public override ISerializationInspector Inspector
        {
            get
            {
                return this._stream.Inspector;
            }

            set
            {
                this._stream.Inspector = value;
            }
        }

        public override void WriteStartObject()
        {
            WriteToken(PortableBinaryToken.StartObjectToken);
        }

        public override void WriteStartMember(
            int memberKey)
        {
            if (memberKey <= 0)
            {
                throw new ArgumentOutOfRangeException("memberKey", "Member key must be a positive integer.");
            }

            WritePackedInt(memberKey);
        }

        public override void WriteEndMember()
        {
            // No end member in this encoding
        }

        public override void WriteEndObject()
        {
            WriteToken(PortableBinaryToken.EndObjectToken);
        }

        public override void WriteStartArray()
        {
            WriteToken(PortableBinaryToken.StartArrayToken);
        }

        public override void WriteEndArray()
        {
            WriteToken(PortableBinaryToken.EndArrayToken);
        }

        public override void WriteNullValue()
        {
            WriteToken(PortableBinaryToken.NullValueToken);
        }

        public override void WriteValue(
            bool value)
        {
            if (value)
            {
                WriteToken(PortableBinaryToken.TrueValueToken);
            }
            else
            {
                WriteToken(PortableBinaryToken.FalseValueToken);
            }
        }

        public override void WriteValue(
            int value)
        {
            // The most significant bit is used for the sign

            byte sign = 0;
            if (value < 0)
            {
                sign = 0x80;
                value = ~value;
            }

            // Remainder of value is the base 256 encoded absolute value

            if (value <= 0x7f)
            {
                WriteLength(1);
                this._writer.Write((byte)(value | sign));
            }
            else if (value <= 0x7fff)
            {
                WriteLength(2);
                this._writer.Write((byte)((value >> 8) | sign));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffff)
            {
                WriteLength(3);
                this._writer.Write((byte)((value >> 16) | sign));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else
            {
                WriteLength(4);
                this._writer.Write((byte)((value >> 24) | sign));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
        }

        public override void WriteValue(
            uint value)
        {
            // Base 256 encoded value

            if (value <= 0xff)
            {
                WriteLength(1);
                this._writer.Write((byte)(value));
            }
            else if (value <= 0xffff)
            {
                WriteLength(2);
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0xffffff)
            {
                WriteLength(3);
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else
            {
                WriteLength(4);
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
        }

        public override void WriteValue(
            long value)
        {
            // The most significant bit is used for the sign

            byte sign = 0;
            if (value < 0)
            {
                sign = 0x80;
                value = ~value;
            }

            // Remainder of value is the base 256 encoded absolute value

            if (value <= 0x7f)
            {
                WriteLength(1);
                this._writer.Write((byte)(value | sign));
            }
            else if (value <= 0x7fff)
            {
                WriteLength(2);
                this._writer.Write((byte)((value >> 8) | sign));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffff)
            {
                WriteLength(3);
                this._writer.Write((byte)((value >> 16) | sign));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffffff)
            {
                WriteLength(4);
                this._writer.Write((byte)((value >> 24) | sign));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffffffff)
            {
                WriteLength(5);
                this._writer.Write((byte)((value >> 32) | sign));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffffffffff)
            {
                WriteLength(6);
                this._writer.Write((byte)((value >> 40) | sign));
                this._writer.Write((byte)(value >> 32));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffffffffffff)
            {
                WriteLength(7);
                this._writer.Write((byte)((value >> 48) | sign));
                this._writer.Write((byte)(value >> 40));
                this._writer.Write((byte)(value >> 32));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else
            {
                WriteLength(8);
                this._writer.Write((byte)((value >> 56) | sign));
                this._writer.Write((byte)(value >> 48));
                this._writer.Write((byte)(value >> 40));
                this._writer.Write((byte)(value >> 32));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
        }

        public override void WriteValue(
            ulong value)
        {
            // Base 256 encoded value

            if (value <= 0xff)
            {
                WriteLength(1);
                this._writer.Write((byte)(value));
            }
            else if (value <= 0xffff)
            {
                WriteLength(2);
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0xffffff)
            {
                WriteLength(3);
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0xffffffff)
            {
                WriteLength(4);
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffffffff)
            {
                WriteLength(5);
                this._writer.Write((byte)(value >> 32));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffffffffff)
            {
                WriteLength(6);
                this._writer.Write((byte)(value >> 40));
                this._writer.Write((byte)(value >> 32));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else if (value <= 0x7fffffffffffff)
            {
                WriteLength(7);
                this._writer.Write((byte)(value >> 48));
                this._writer.Write((byte)(value >> 40));
                this._writer.Write((byte)(value >> 32));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
            else
            {
                WriteLength(8);
                this._writer.Write((byte)(value >> 56));
                this._writer.Write((byte)(value >> 48));
                this._writer.Write((byte)(value >> 40));
                this._writer.Write((byte)(value >> 32));
                this._writer.Write((byte)(value >> 24));
                this._writer.Write((byte)(value >> 16));
                this._writer.Write((byte)(value >> 8));
                this._writer.Write((byte)(value));
            }
        }

        public override void WriteValue(
            float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                // Convert to network order (big-endian)
                Array.Reverse(bytes);
            }
            WriteLength(bytes.Length);
            this._writer.Write(bytes, 0, bytes.Length);
        }

        public override void WriteValue(
            double value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                // Convert to network order (big-endian)
                Array.Reverse(bytes);
            }
            WriteLength(bytes.Length);
            this._writer.Write(bytes, 0, bytes.Length);
        }

        public override void WriteValue(
            byte[] value)
        {
            if (null == value)
            {
                WriteToken(PortableBinaryToken.NullValueToken);
            }
            else
            {
                WriteLength(value.Length);
                this._writer.Write(value, 0, value.Length);
            }
        }

        public override void WriteValue(
            string value)
        {
            if (null == value)
            {
                WriteToken(PortableBinaryToken.NullValueToken);
            }
            else
            {
                byte[] bytes = Encoding.UTF8.GetBytes(value);
                WriteLength(bytes.Length);
                this._writer.Write(bytes, 0, bytes.Length);
            }
        }

        public override void Flush()
        {
            this._writer.Flush();
        }

        private void WriteToken(
            int token)
        {
            if (token >= 0)
            {
                throw new ArgumentOutOfRangeException("token", "Token value must be a negative integer.");
            }

            WritePackedInt(token);
        }

        private void WriteLength(
            int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length", "Length must be a non-negative integer.");
            }

            WritePackedInt(length);
        }

        private void WritePackedInt(
            int value)
        {
            byte byteValue = 0;

            // Bit 6 contains the sign
            if (value < 0)
            {
                // Set the sign bit
                byteValue = 0x40;

                // Negate the value (so it is non-negative)
                value = ~value;
            }

            // Bits 0-5 contain the 6 least significant bits of the absolute value
            byteValue |= (byte)(value & 0x3F);

            // Shift away the 6 bits just captured
            value = value >> 6;

            // Check for another byte to write
            while (value != 0)
            {
                // Set the continuation bit (7)
                byteValue |= 0x80;

                // Write the current byte value
                this._writer.Write((byte)byteValue);

                // Get the next 7 least significant bits of the value
                byteValue = (byte)(value & 0x7F);

                // Shift away the 7 bits just captured
                value = value >> 7;
            }

            // Write the final byte
            this._writer.Write(byteValue);
        }
    }
}