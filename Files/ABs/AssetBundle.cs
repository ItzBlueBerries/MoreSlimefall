﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

internal class AB
{
    public static byte[] GetAsset(string path)
    {
        Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Assembly.GetExecutingAssembly().GetName().Name + "." + path);
        byte[] array = new byte[manifestResourceStream.Length];
        manifestResourceStream.Read(array, 0, array.Length);
        return array;
    }

    internal static AssetBundle more_slimefall = AssetBundle.LoadFromMemory(GetAsset("Files.ABs.more_slimefall"));
}
