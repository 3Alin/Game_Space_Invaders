using NAudio.Wave;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace Proiect_Space_Invaders.Library
{
    internal static class AssetManager
    {
        private static readonly string path = "..\\..\\Assets\\";

        public static readonly Bitmap[] playerShip = new Bitmap[5];
        public static readonly Bitmap[] enemyShip = new Bitmap[5];
        public static readonly Bitmap[] thrusters = new Bitmap[2];

        public static bool muteSound = false;
        public static readonly int MAX_SOUNDS = 20;
        public static int soundsCount = 0;

        public static void loadAssets()
        {
            Bitmap tmp = new Bitmap(path + "player_ship.png");
            int tileSize = tmp.Width / 5;
            for (int i = 0; i < 5; i++)
            {
                int index = tileSize * i;
                playerShip[i] = tmp.Clone(new Rectangle(index, 0, tileSize, tmp.Height), PixelFormat.Format64bppArgb);
            }

            tmp = new Bitmap(path + "enemy_ship.png");
            tileSize = tmp.Width / 5;
            for (int i = 0; i < 5; i++)
            {
                int index = tileSize * i;
                enemyShip[i] = tmp.Clone(new Rectangle(index, 0, tileSize, tmp.Height), PixelFormat.Format64bppArgb);
                enemyShip[i].RotateFlip(RotateFlipType.Rotate180FlipX);
            }
        }

        public static void playSound(string soundName)
        {
            if (muteSound || soundsCount > MAX_SOUNDS)
                return;

            AudioFileReader stream = new AudioFileReader(path + soundName);
            WaveOut sound = new WaveOut();

            if (soundName == "shoot2.wav")
                stream.Volume = 0.3f;

            sound.Init(stream);
            sound.Play();
            soundsCount++;
            Task.Delay(500).ContinueWith(t =>
            {
                sound.Dispose();
                stream.Dispose();
                soundsCount--;
            });
        }
    }
}
