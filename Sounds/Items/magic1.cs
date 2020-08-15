using IL.Terraria;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;
using Microsoft.Xna.Framework.Audio;
using System.Security.Cryptography;

namespace nalydmod.Sounds.Items
{
    public class magic1 : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            soundInstance = sound.CreateInstance();
            soundInstance.Volume = 0.5f;
            soundInstance.Pan = pan;
            soundInstance.Pitch = -1.0f;
            Terraria.Main.PlaySoundInstance(soundInstance);
            return soundInstance;
        }
    }
    
}




