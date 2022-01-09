using System;
using System.Collections.Generic;
using System.Web;

/* 
    https://projecteuler.net/problem=1  */


namespace NetEuler
{
    static class MagnetParse
    {
        public static void Solve()
        {
            //https://en.wikipedia.org/wiki/Magnet_URI_scheme#Format
            // string magnetURI = "magnet:?xt=urn:btih:ec7a402ff515d80f30f6244847b672ae9fbe5d7a&dn=2021-01-11-raspios-buster-armhf-lite.zip&tr=http%3a%2f%2ftracker.raspberrypi.org%3a6969%2fannounce";

            string magnetURI2 = "magnet:?xt=urn:btih:ec7a402ff515d80f30f6244847b672ae9fbe5d7a&dn=2021-01-11-raspios-buster-armhf-lite.zip&tr=http%3a%2f%2ftracker.raspberrypi.org%3a6969%2fannounce&tr=udp%3a%2f%2ftracker.openbittorrent.com%3a6969%2f&tr=udp%3a%2f%2ftracker.cyberia.is%3a6969%2fannounce&tr=udp%3a%2f%2fipv6.tracker.harry.lu%3a80%2fannounce&tr=udp%3a%2f%2fipv4.tracker.harry.lu%3a80%2fannounce&tr=udp%3a%2f%2fexplodie.org%3a6969%2fannounce&tr=udp%3a%2f%2ftracker.torrent.eu.org%3a451&tr=udp%3a%2f%2fexodus.desync.com%3a6969%2fannounce&tr=udp%3a%2f%2ftracker.internetwarriors.net%3a1337%2fannounce&tr=udp%3a%2f%2f9.rarbg.me%3a2770%2fannounce&tr=udp%3a%2f%2ftracker.opentrackr.org%3a1337%2fannounce";

            // string hash = "ec7a402ff515d80f30f6244847b672ae9fbe5d7a";
            // string name = "2021-01-11-raspios-buster-armhf-lite.zip";

            // MagnetURI uri = new MagnetURI()
            // {
            //     hash = hash,
            //     name = name
            // };

            MagnetURI uri = new MagnetURI(magnetURI2);
            uri.printReadout();
            Console.WriteLine("");
            Console.WriteLine(uri.ToString());
        }
    }
    public class MagnetURI{
        public MagnetURI(){
            this.hash = string.Empty;
            this.name = string.Empty;
            trackers = new List<string>();
        }
        public MagnetURI(string magnetLink){
            this.hash = magnetLink.Substring(prefix.Length, _hashLength);
            string linkAfterHash = magnetLink.Substring(prefix.Length + _hashLength + _dn.Length);
            if(!linkAfterHash.Contains(_tr)){
                this.name = linkAfterHash;
                trackers = new List<string>();
            }
            else{
                this.name = linkAfterHash.Substring(0, linkAfterHash.IndexOf(_tr));
                string trackersOnly = linkAfterHash.Substring(this.name.Length);
                trackers = new List<String>();
                foreach(string s in trackersOnly.Split(_tr))
                {
                    if(!string.IsNullOrWhiteSpace(s))
                    {
                        trackers.Add(HttpUtility.UrlDecode(s));
                    }
                }
            }
        }
        public override string ToString(){
            string uri = string.Format(prefix + hash + _dn + "{0}", name);
            foreach(string tr in trackers){
                uri += _tr + tr;
            }
            return uri;
        }
        public void printReadout(){
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Hash: {0}", hash);
            Console.WriteLine("");
            Console.WriteLine("Trackers:");
            foreach(string tr in trackers){
                Console.WriteLine(tr);
            }
        }
        public string hash{ get; set; }
        public string name { get; set; }
        private List<string> trackers { get; set; }
        private readonly string prefix = "magnet:?xt=urn:btih:";
        private readonly string _dn = "&dn=";
        private readonly string _tr = "&tr=";
        private readonly int _hashLength = 40;
    }
}