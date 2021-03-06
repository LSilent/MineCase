﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MineCase.Serialization;

namespace MineCase.Protocol.Play
{
#if !NET46
    [Orleans.Concurrency.Immutable]
#endif
    [Packet(0x23)]
    public class JoinGame : ISerializablePacket
    {
        [SerializeAs(DataType.Int)]
        public int EID;

        [SerializeAs(DataType.Byte)]
        public byte GameMode;

        [SerializeAs(DataType.Int)]
        public int Dimension;

        [SerializeAs(DataType.Byte)]
        public byte Difficulty;

        [SerializeAs(DataType.Byte)]
        public byte MaxPlayers;

        [SerializeAs(DataType.String)]
        public string LevelType;

        [SerializeAs(DataType.Boolean)]
        public bool ReducedDebugInfo;

        public void Serialize(BinaryWriter bw)
        {
            bw.WriteAsInt(EID);
            bw.WriteAsByte(GameMode);
            bw.WriteAsInt(Dimension);
            bw.WriteAsByte(Difficulty);
            bw.WriteAsByte(MaxPlayers);
            bw.WriteAsString(LevelType);
            bw.WriteAsBoolean(ReducedDebugInfo);
        }
    }
}
