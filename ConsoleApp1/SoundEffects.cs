using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.Raylib;

namespace ConsoleApp1
{
    public class SoundEffects
    {
        //Hold sounds files
        Sound[] sounds = new Sound[4];
        public SoundEffects()
        {
            //Load Sounds
            sounds[0] = LoadSound("../../../Sounds/Buzzer.mp3");
            sounds[1] = LoadSound("../../../Sounds/Boom.mp3");
            sounds[2] = LoadSound("../../../Sounds/Ping.mp3");
            sounds[3] = LoadSound("../../../Sounds/")
          


        }

        public void PlayBuzzerSound()
        {
            PlaySound(sounds[0]);
        }

        public void EndSounds()
        {
            UnloadSound(sounds[0]);
            CloseAudioDevice();
        }
    }
}
