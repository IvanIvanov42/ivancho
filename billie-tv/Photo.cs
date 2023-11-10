﻿namespace billie_tv
{
    public class Photo
    {
        public int Id { get; set; }
        public Type MediaType { get; set; }
        public string MediaURL { get; set; }
        public string Username { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public enum Type
    {
        Photo,
        Reel
    }
}
