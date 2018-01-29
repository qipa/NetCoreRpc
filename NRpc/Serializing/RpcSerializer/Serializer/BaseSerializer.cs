﻿using NRpc.Utils;

namespace NRpc.Serializing.RpcSerializer.Serializer
{
    /// <summary>
    /// Copyright (C) 2018 备胎 版权所有。
    /// 类名：BaseSerializer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：
    /// 创建标识：yjq 2018/1/26 10:05:45
    /// </summary>
    public abstract class BaseSerializer
    {
        public abstract byte[] GeteObjectBytes(object obj);

        public byte[] NullBytes()
        {
            return ByteUtil.Combine(RpcSerializerUtil.Bytes_Object, ByteUtil.ZeroLengthBytes, ByteUtil.EmptyBytes);
        }
    }
}