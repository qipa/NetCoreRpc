﻿using NRpcSerializer.Utils;

namespace NRpcSerializer.Deserializer
{
    /// <summary>
    /// 类名：ByteDeserializer.cs
    /// 类功能描述：
    /// 创建标识：yjq 2018/5/7 16:30:57
    /// </summary>
    public sealed class ByteDeserializer : BaseDeserializer
    {
        public override object GetObject(byte[] inputBytes, int startOffset, out int nextStartOffset)
        {
            return ByteUtil.DecodeByte(inputBytes, startOffset, out nextStartOffset);
        }
    }
}