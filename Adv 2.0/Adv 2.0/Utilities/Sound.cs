using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adv_2._0.Utilities
{
    public class Sound
    {
        public static void Song()
        {
            Note[] Range =
            {
                
            };
        }

        // Play the notes in a song.
        protected static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        public static void Music()
        {
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\User\Downloads\inspirational.mp3"))
            {
                player.PlaySync();
            }
        }

        // Define the frequencies of notes in an octave, as well as 
        // silence (rest).
        protected enum Tone
        {
            REST = 0,
            C2 = 65,
            D2 = 73,
            D2Sharp = 77,
            E2 = 82,
            F2 = 87,
            F2Sharp = 92,
            G2 = 98,
            G2Sharp = 103,
            A2 = 110,
            A2Sharp = 116,
            B2 = 123,
            C3 = 130,
            C3Sharp = 138,
            D3 = 146,
            D3Sharp = 155, 
            E3 = 164,
            F3 = 174, 
            F3Sharp = 185,
            G3 = 196,
            A3 = 220,
            A3Sharp = 233,
            B3 = 246,
            C4 = 261,
            C4Sharp = 277,
            D4 = 293,
            D4Sharp = 311,
            E4 = 329,
            F4 = 349,
            F4Sharp = 369,
            G4 = 392,
            G4Sharp = 415,
            A4 = 440,
            A4Sharp = 466,
            B4 = 493,
            C5 = 523,
            C5Sharp = 554,
            D5 = 587,
            D5Sharp = 622,
            E5 = 659,
            F5 = 698, 
            F5Sharp = 739,
            G5 = 783,
            G5Sharp = 830,
            A5 = 880,
            A5Sharp = 932,
            B5 = 987,
            C6 = 1046
        }

        // Define the duration of a note in units of milliseconds.
        protected enum Duration
        {
            WHOLE = 3400,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        // Define a note as a frequency (tone) and the amount of 
        // time (duration) the note plays.
        protected struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }
}
