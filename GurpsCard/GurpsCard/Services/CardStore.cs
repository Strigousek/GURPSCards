using GurpsCard.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GurpsCard.Services
{
    public class CardStore
    {
        public List<Card> Cards { get; set; }

        public CardStore()
        {
            Cards = new List<Card>()
            {
                new AttackCard
                {
                    Name = "Attack",
                    Description =  $"Use this maneuver to make an armed or unarmed attack in melee combat, " +
                                   $"or to use a thrown or missile weapon in ranged combat. To use a weapon to attack, it must be ready. If you are using a melee weapon or unarmed attack, your target must be within reach." +
                                   $"If you are using a ranged weapon, your target must be within the weapon’s Max range.",
                    ActiveDefense = "Any.",
                    Movement = "Step. You may step and attack, or attack and then step. To move further and still attack, take All-Out Attack or Move and Attack.",
                    Page = "365"
                },

                new AttackCard
                {
                    Name = "Move and Attack",
                    Description =  $"Move as described for the Move Maneuver, but during or after your move you may make a single, poorly aimed attack." +
                    $"If you are making a ranged attack, you have a penalty of -2 or the weapon’s Bulk rating, whichever is worse. " +
                    $"If you are making a melee attack other than a slam, you have -4 to your skill and your adjusted skill cannot exceed 9.",
                    ActiveDefense = "Dodge or Block only. You cannot Parry,and you may not retreat.",
                    Movement = "Full Move.",
                    Page = "365"
                },

                new AttackCard
                {
                    Name = "Feint",
                    Description = $"“Fake” a melee attack. You cannot Feint someone unless you could have hit him with a melee attack. This maneuver is not an attack, though, and does not make your weapon unready. The full procedure for performing a Feint maneuver is found on page 365 of the Campaigns book.",
                    ActiveDefense = "Any. However, if you Feint and then parry with an unbalanced weapon, you cannot attack on your next turn. This makes the Feint pointless",
                    Movement = "Step.",
                    Page = "365"
                },


                new AttackCard
                {
                    Name = "All-Out Attack",
                    Type = "Meelee - Determined",
                    Description =  $"Attack any foe with a ready weapon, making no effort to defend against enemy attacks. Determined: Make a single attack at +4 to hit",
                    ActiveDefense = "You may make no active defenses at all until your next turn.",
                    Movement = "You may move up to half your Move, but you can only move forward.",
                    Page = "365"
                }
            };
        }
    }
}
