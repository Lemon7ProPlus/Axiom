﻿/* ----------------------------------------------------------------------
Axiom UI
Copyright (C) 2017-2020 Matt McManis
https://github.com/MattMcManis/Axiom
https://axiomui.github.io
mattmcmanis@outlook.com

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>. 
---------------------------------------------------------------------- */

using System.Collections.Generic;
using System.Collections.ObjectModel;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Controls
{
    public class Containers
    {
        // --------------------------------------------------
        // Containers
        // --------------------------------------------------

        // -------------------------
        // webm
        // -------------------------
        public class WebM
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "VP8",
                "VP9",
                "Copy"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "Vorbis",
                "Opus",
                "Copy",
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "Burn"
            };
        }



        // -------------------------
        // mp4
        // -------------------------
        public class MP4
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "x264",
                "x265",
                "Copy"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "AC3",
                "AAC",
                "DTS",
                "Copy",
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "MOV Text",
                "Burn",
                "Copy"
            };
        }



        // -------------------------
        // mkv
        // -------------------------
        public class MKV
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "x264",
                "x265",
                "VP8",
                "VP9",
                "AV1",
                "FFV1",
                "MagicYUV",
                "HuffYUV",
                "Theora",
                "Copy"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "AC3",
                "AAC",
                "DTS",
                "Vorbis",
                "Opus",
                "LAME",
                "FLAC",
                "PCM",
                "Copy",
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "MOV Text",
                "SSA",
                "SRT",
                "Burn",
                "Copy"
            };
        }



        // -------------------------
        // m2v
        // -------------------------
        public class M2V
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "MPEG-2",
                "Copy"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // mpg
        // -------------------------
        public class MPG
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "MPEG-2",
                "MPEG-4",
                "Copy"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "MP2",
                "AC3",
                "AAC",
                "DTS",
                "LAME",
                "PCM",
                "Copy",
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "SRT",
                "Burn",
                "Copy"
            };
        }



        // -------------------------
        // avi
        // -------------------------
        public class AVI
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "MPEG-2",
                "MPEG-4",
                "Copy"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "MP2",
                "AC3",
                "AAC",
                "DTS",
                "LAME",
                "PCM",
                "Copy",
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "SRT",
                "Burn",
                "Copy"
            };
        }



        // -------------------------
        // ogv
        // -------------------------
        public class OGV
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"

            };
            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "Theora",
                "Copy"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "Vorbis",
                "Copy",
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "Copy"
            };
        }



        // -------------------------
        // mp3
        // -------------------------
        public class LAME
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "LAME",
                "Copy"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // m4a
        // -------------------------
        public class M4A
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "AAC",
                "ALAC",
                "Copy"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // ogg
        // -------------------------
        public class OGG
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "Opus",
                "Vorbis",
                "Copy"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // flac
        // -------------------------
        public class FLAC
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "FLAC",
                "Copy"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // wav
        // -------------------------
        public class WAV
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "PCM",
                "Copy"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // jpg
        // -------------------------
        public class JPG
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Image",
                "Sequence"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "JPEG"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "Burn"
            };
        }



        // -------------------------
        // png
        // -------------------------
        public class PNG
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Image",
                "Sequence"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "PNG"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "Burn"
            };
        }



        // -------------------------
        // webp
        // -------------------------
        public class WebP
        {
            // Media Type
            public static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Image",
                "Sequence"
            };

            // Codecs
            public static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "WebP"
            };

            public static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None",
                "Burn"
            };
        }



    }
}
