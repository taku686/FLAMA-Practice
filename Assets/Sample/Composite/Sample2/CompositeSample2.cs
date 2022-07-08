using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeSample2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SongComponent industrialMusic = new SongGroup("Industrial Music",
            "Industrial music is a genre of experimental music that draws on transgressive and provocative themes. The term was coined in the mid-1970s with the founding of Industrial Records by Genesis P-Orridge of Throbbing Gristle and Monte Cazazza; on Throbbing Gristle's debut album The Second Annual Report, they coined the slogan \"industrial music for industrial people\".");
        SongComponent heavyMetalMusic = new SongGroup("Heavy Metal Music",
            "Heavy metal is a genre of rock music[1] that developed in the late 1960s and early 1970s, largely in the United States and the United Kingdom.[2] With roots in blues rock and psychedelic rock,[3] the bands that created heavy metal developed a thick, massive sound, characterized by highly amplified distortion, extended guitar solos, emphatic beats, and overall loudness. Heavy metal lyrics and performance styles are often associated with masculinity, aggression, and machismo.[3]");
        SongComponent dubstepMusic = new SongGroup("Dubstep Music",
            "Dubstep /ˈdʌbstɛp/ is a genre of electronic dance music that originated in South London, England. It emerged in the late 1990s as a development within a lineage of related styles such as 2-step garage, broken beat, drum and bass, jungle, dub and reggae.[2] In the UK the origins of the genre can be traced back to the growth of the Jamaican sound system party scene in the early 1980s.[2][3] The music generally features syncopated drum and percussion patterns with bass lines that contain prominent sub bass frequencies.");

        SongComponent everySong = new SongGroup("Song List", "Every Song available");
        everySong.Add(industrialMusic);
        industrialMusic.Add(new Song("Head Like a Hole", "NIN", 1990));
        industrialMusic.Add(new Song("headhunter", "front 242", 1988));
        // see: here we are adding a group into a group and build up the hierarchy!!!!
        industrialMusic.Add(dubstepMusic);
        dubstepMusic.Add(new Song("Centipede", "Knife Party", 2012));
        dubstepMusic.Add(new Song("Tetris", "doctor P", 2011));

        everySong.Add(heavyMetalMusic);
        heavyMetalMusic.Add(new Song("War Pigs", "Black Sabath", 1970));
        heavyMetalMusic.Add(new Song("Ace of spades", "Motorhead", 1980));

        DiscJockey crazyLarry = new DiscJockey(everySong);
        crazyLarry.GetSongList();
    }
}