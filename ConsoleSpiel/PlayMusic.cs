using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace ConsoleSpiel
{
    public class PlayMusic
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string filepath;
        public PlayMusic(string filepath)
        {
            Load(filepath);
        }

        private void Load(string filepath)
        {
            Stop();

            audioFile = new AudioFileReader(filepath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);

        }

        public void PlayLooping()
        {
            if(outputDevice != null)
            {
                outputDevice.Play();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
           audioFile.Position = 0;
           outputDevice.Play();
        }

        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.PlaybackStopped -= OnPlaybackStopped;
                outputDevice.Dispose();
                outputDevice = null;
            }

            if(audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }
    }
}
