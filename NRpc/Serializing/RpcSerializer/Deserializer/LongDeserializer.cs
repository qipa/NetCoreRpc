﻿using NRpc.Utils;

namespace NRpc.Serializing.RpcSerializer.Deserializer
{
    /// <summary>
    /// Copyright (C) 2018 备胎 版权所有。
    /// 类名：LongDeserializer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：
    /// 创建标识：yjq 2018/1/26 16:09:30
    /// </summary>
    public sealed class LongDeserializer : BaseDeserializer
    {
        public override object GetObject(byte[] inputBytes, int startOffset, out int nextStartOffset)
        {
            return ByteUtil.DecodeLong(inputBytes, startOffset, out nextStartOffset);
        }
    }
}