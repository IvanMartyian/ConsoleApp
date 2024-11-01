﻿using System;
using System.Collections.Generic;
using System.IO;
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
           this.filepath = filepath;
            Initialize();
        }

        private void Initialize()
        {
            Stop();

            if(!File.Exists(filepath))
            {
                throw new FileNotFoundException ($"Die Audiodatei wurde nicht gefunden: {filepath}");
            }

            try
            {
                audioFile = new AudioFileReader(filepath);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Initialisieren der Audiodatei: {ex.Message}");
                throw;
            }
        }
        //Startet das angegebene Music-Objekt von der Stelle, an der es das Letze Mal beendet wurde.
        public void PlayLooping()
        {
            try
            {
                if (outputDevice == null)
                {
                    Initialize();
                }
                if (outputDevice.PlaybackState != PlaybackState.Playing)
                {
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                    outputDevice.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Abspielen der Musik: {ex.Message}"); //TODO: Die Musik wird nicht richtig gestoppt; Die Musik kann gestoppt werden, aber nach dem Stoppen kann die gleiche Musik nicht erneut abgespielt werden.
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            try
            {
                Initialize();
                if (audioFile != null && outputDevice != null)
                {
                    audioFile.Position = 0;
                    outputDevice.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Neustarten der Wiedergabe: {ex.Message}");
                // Optionale Neuinitialisierung
                Initialize();
            }
        }
        //Stopt Music-Objekt und löscht alle Wiedergabeobjekt deshalb muss die objekt neu Inizializiren.
        public void Stop()
        {
            if (outputDevice != null)
            {
                if (outputDevice != null)
                {
                    outputDevice.PlaybackStopped -= OnPlaybackStopped;
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    //outputDevice = null;
                }
                if (audioFile != null)
                {
                    audioFile.Dispose();
                    audioFile = null;
                }
            }
        }

        public bool IsPlaying()
        {
            return outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing;
        }

        //Stopt das angegegebene Music-Objekt an den Moment, wenn sie abgespielt wird, startet von gleichen Stelle die Music abspilen
        internal void StopPlaying()
        {
            if (outputDevice != null)
            {
                outputDevice.PlaybackStopped -= OnPlaybackStopped;
                outputDevice.Stop();
            }
        }
    }
}
