﻿using System;

namespace WindBot
{
    public class WindBotInfo
    {
        public string Name { get; set; }
        public string Deck { get; set; }
        public string Dialog { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string HostInfo { get; set; }
        public string DeckPath { get; set; }
        public int Version { get; set; }
        public int Hand { get; set; }
        public bool Debug { get; set; }
        public bool Chat { get; set; }

        public WindBotInfo()
        {
            Name = "WindBot";
            Deck = null;
            Dialog = "default";
            Host = "127.0.0.1";
            Port = 7911;
            HostInfo = "";
            DeckPath = null;
            Version = 0x1345;
            Hand = 0;
            Debug = false;
            Chat = true;
        }
    }
}
