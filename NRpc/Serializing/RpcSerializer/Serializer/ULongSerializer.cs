﻿using NRpc.Utils;
using System;

namespace NRpc.Serializing.RpcSerializer.Serializer
{
    /// <summary>
    /// Copyright (C) 2018 备胎 版权所有。
    /// 类名：ULongSerializer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：
    /// 创建标识：yjq 2018/1/26 16:13:06
    /// </summary>
    public sealed class ULongSerializer : BaseSerializer
    {
        public override byte[] GeteObjectBytes(object obj)
        {
            if (obj == null)
            {
                return ByteUtil.Combine(RpcSerializerUtil.Bytes_ULong, ByteUtil.ZeroLengthBytes, ByteUtil.EmptyBytes);
            }
            else
            {
                return ByteUtil.Combine(RpcSerializerUtil.Bytes_ULong, BitConverter.GetBytes((ulong)obj));
            }
        }
    }
}