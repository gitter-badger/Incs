﻿using System;
using static Monsajem_Incs.Collection.Array.Extentions;
using static System.Text.Encoding;

namespace Monsajem_Incs.Serialization
{
    public partial class Serialization
    {
        private SerializeInfo WriteSerializer(SerializeData Data,Type Type)
        {
            var Sr = SerializeInfo.GetSerialize(Type);
            VisitedInfoSerialize<object>(Data, Sr.Type, () => (Sr.NameAsByte, null));
            return Sr;
        }

        private SerializeInfo ReadSerializer(DeserializeData Data)
        {
            var Info = VisitedInfoDeserialize(Data,() =>
            {
                return Read(Data);
            });
            return SerializeInfo.GetSerialize(Info);
        }

        private byte[] Write(params string[] str)
        {
            byte[] Results = new byte[0];
            for (int i = 0; i < str.Length; i++)
            {
                var UTF8_Data = UTF8.GetBytes(str[i]);
                var Result = new byte[UTF8_Data.Length + 4];
                System.Array.Copy(BitConverter.GetBytes(UTF8_Data.Length), 0, Result, 0, 4);
                System.Array.Copy(UTF8_Data, 0, Result, 4, UTF8_Data.Length);
                Insert(ref Results, Result);
            }
            return Results;
        }

        private string Read(DeserializeData Data)
        {
            var Len = BitConverter.ToInt32(Data.D_Data, Data. From);
            Data.From += 4;
            var Result = UTF8.GetString(Data.D_Data, Data.From, Len);
            Data. From += Result.Length;
            return Result;
        }
    }

}
