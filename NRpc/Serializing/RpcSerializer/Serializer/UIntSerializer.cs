﻿using NRpc.Utils;
using System;

namespace NRpc.Serializing.RpcSerializer.Serializer
{
    /// <summary>
    /// Copyright (C) 2018 备胎 版权所有。
    /// 类名：UIntSerializer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：
    /// 创建标识：yjq 2018/1/26 15:47:01
    /// </summary>
    public sealed class UIntSerializer : BaseSerializer
    {
        public override byte[] GeteObjectBytes(object obj)
        {
            if (obj == null)
            {
                return ByteUtil.Combine(RpcSerializerUtil.Bytes_UInt, ByteUtil.ZeroLengthBytes, ByteUtil.EmptyBytes);
            }
            else
            {
                return ByteUtil.Combine(RpcSerializerUtil.Bytes_UInt, BitConverter.GetBytes((uint)obj));
            }
        }
    }
}