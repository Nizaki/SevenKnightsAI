﻿using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidLobbyPM
    {
        public static readonly PixelMapping AttackedTab = new PixelMapping
        {
            X = 350,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DefeatedTab = new PixelMapping
        {
            X = 800,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping EnterButton = new PixelMapping
        {
            X = 868,
            Y = 200,
            Color = 13873749,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GreenIconOnNewTab = new PixelMapping
        {
            X = 214,
            Y = 69,
            Color = 45085,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Border = new PixelMapping
        {
            X = 46,
            Y = 494,
            Color = 8877126,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Button = new PixelMapping
        {
            X = 120,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ManageParty2Border = new PixelMapping
        {
            X = 370,
            Y = 498,
            Color = 6773548,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty2Button = new PixelMapping
        {
            X = 323,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NewTab = new PixelMapping
        {
            X = 550,
            Y = 70,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedIconOnDefeatedTab = new PixelMapping
        {
            X = 718,
            Y = 57,
            Color = 13183490,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 850,
            Y = 130,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}