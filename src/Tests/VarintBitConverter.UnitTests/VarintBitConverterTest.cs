using System;
using Xunit;

namespace VarintBitConverterUnitTests
{
    public class VarintBitConverterTest
    {
        [Fact]
        public void VarintEncodeAndDecodeByteMaxValue()
        {
            const byte number = Byte.MaxValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToByte(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeByteMinValue()
        {
            const byte number = Byte.MinValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToByte(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeByteZero()
        {
            const byte number = 0;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToByte(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeByte()
        {
            const byte number = Byte.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToByte(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt16MaxValue()
        {
            const short number = Int16.MaxValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt16MinValue()
        {
            const short number = Int16.MinValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt16Zero()
        {
            const short number = 0;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt16()
        {
            const short number = Int16.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt16MaxValue()
        {
            const ushort number = UInt16.MaxValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt16MinValue()
        {
            const ushort number = UInt16.MinValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeZero()
        {
            const ushort number = UInt16.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt16()
        {
            const ushort number = UInt16.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt16(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt32MaxValue()
        {
            const int number = Int32.MaxValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt32MinValue()
        {
            const int number = Int32.MinValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt32Zero()
        {
            const int number = 0;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt32()
        {
            const int number = Int32.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt32MaxValue()
        {
            const uint number = UInt32.MaxValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt32MinValue()
        {
            const uint number = UInt32.MinValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt32Zero()
        {
            const uint number = 0;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt32()
        {
            const uint number = UInt32.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt32(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt64MaxValue()
        {
            const long number = Int64.MaxValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt64(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt64MinValue()
        {
            const long number = Int64.MinValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt64(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt64Zero()
        {
            const long number = 0;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt64(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeInt64()
        {
            const long number = Int64.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToInt64(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt64MaxValue()
        {
            const ulong number = UInt64.MaxValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt64(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt64MinValue()
        {
            const ulong number = UInt64.MinValue;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt64(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt64Zero()
        {
            const ulong number = 0;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt64(encoded));
        }

        [Fact]
        public void VarintEncodeAndDecodeUInt64()
        {
            const ulong number = UInt64.MaxValue / 2;
            var encoded = VarintBitConverter.GetVarintBytes(number);
            Assert.Equal(number, VarintBitConverter.ToUInt64(encoded));
        }
    }
}
