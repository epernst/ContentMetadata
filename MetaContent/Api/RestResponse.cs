﻿using System.Xml.Serialization;
using Telligent.Evolution.Extensibility.Rest.Version2;

[XmlRoot(ElementName = "Response")]
public class RestResponse : IRestResponse
{
    public object Data { get; set; }
    public string[] Errors { get; set; }
    public string Name { get; set; }
}
