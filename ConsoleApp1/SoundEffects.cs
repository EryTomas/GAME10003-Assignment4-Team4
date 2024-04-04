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
            sounds[3] = LoadSound("../../../Sounds/Pong.mp3");
            sounds[4] = LoadSound("../../../Sounds/Bell.mp3");

        }
        public void PlayBuzzerSound()
        {
            PlaySound(sounds[0]);
        }
        public void PlayBoomSound()
        {
            PlaySound(sounds[1]);
        }
        public void PlayPingSound()
        {
            PlaySound(sounds[2]);
        }

    }

}

