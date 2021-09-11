using System;
using titanfall2_rp.enums;

namespace titanfall2_rp
{
    public partial class Titanfall2Api
    {
        private const string HelpMeBruh =
            "Getting this value is not supported. " +
            "If you want this to be possible, you'll need to contribute this yourself or tell me how the heck to get it.";

        /// <summary>
        /// Inside this class are multiplayer subclasses for each game mode (because the stats are different
        /// based on the game type. They'll also be in different memory locations).
        /// </summary>
        public class MpGameStats
        {
            private Coliseum _coliseum;
            private Attrition _attrition;
            private Skirmish _skirmish;
            private AmpedHardpoint _ampedHardpoint;
            private BountyHunt _bountyHunt;
            private CaptureTheFlag _captureTheFlag;
            private LastTitanStanding _lastTitanStanding;
            private PilotsVersusPilots _pilotsVersusPilots;
            private LiveFire _liveFire;
            private MarkedForDeath _markedForDeath;
            private TitanBrawl _titanBrawl;
            private FrontierDefense _frontierDefense;
            private readonly Titanfall2Api _tf2Api;

            public MpGameStats(Titanfall2Api titanfall2Api)
            {
                _coliseum = new Coliseum(titanfall2Api);
                _attrition = new Attrition(titanfall2Api);
                _skirmish = new Skirmish(titanfall2Api);
                _ampedHardpoint = new AmpedHardpoint(titanfall2Api);
                _bountyHunt = new BountyHunt(titanfall2Api);
                _captureTheFlag = new CaptureTheFlag(titanfall2Api);
                _lastTitanStanding = new LastTitanStanding(titanfall2Api);
                _pilotsVersusPilots = new PilotsVersusPilots(titanfall2Api);
                _liveFire = new LiveFire(titanfall2Api);
                _markedForDeath = new MarkedForDeath(titanfall2Api);
                _titanBrawl = new TitanBrawl(titanfall2Api);
                _frontierDefense = new FrontierDefense(titanfall2Api);
                _tf2Api = titanfall2Api;
            }

            public class Coliseum
            {
                private readonly Titanfall2Api _tf2Api;

                public Coliseum(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }
            }

            public class Attrition
            {
                private readonly Titanfall2Api _tf2Api;

                public Attrition(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }

                /// <summary>
                /// Get the score of team 1. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 1</returns>
                public int GetTeam1Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x1121814C);
                }

                /// <summary>
                /// Get the score of team 2. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 2</returns>
                public int GetTeam2Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x11218CA0);
                }

                /// <summary>
                /// Get the score of the current user.
                /// </summary>
                /// <returns>the user's score</returns>
                public int GetMyScore()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the pilot kills of the current user.
                /// </summary>
                /// <returns>the number of pilots the user has killed</returns>
                public int GetMyPilotKills()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the titan kills of the current user.
                /// </summary>
                /// <returns>the number of titans the user has killed</returns>
                public int GetMyTitanKills()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the minion kills of the current user.
                /// </summary>
                /// <returns>the number of minions the user has killed</returns>
                public int GetMyMinionKills()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }
            }

            public class Skirmish
            {
                private readonly Titanfall2Api _tf2Api;

                public Skirmish(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }
            }

            public class AmpedHardpoint
            {
                private readonly Titanfall2Api _tf2Api;

                public AmpedHardpoint(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }

                /// <summary>
                /// Get the score of team 1. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 1</returns>
                public int GetTeam1Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x1121814C);
                }

                /// <summary>
                /// Get the score of team 2. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 2</returns>
                public int GetTeam2Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x11218CA0);
                }

                /// <summary>
                /// Get the assault score of the current user.
                /// </summary>
                /// <returns>the user's assault score</returns>
                public int GetMyAssaultScore()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the defense score of the current user.
                /// </summary>
                /// <returns>the user's defense score</returns>
                public int GetMyDefenseScore()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the kill count of the current user.
                /// </summary>
                /// <returns>the user's kill count</returns>
                public int GetMyKills()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }
            }

            public class BountyHunt
            {
                private readonly Titanfall2Api _tf2Api;

                public BountyHunt(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }

                /// <summary>
                /// Get the score of team 1. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 1</returns>
                public int GetTeam1Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x1121814C);
                }

                /// <summary>
                /// Get the score of team 2. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 2</returns>
                public int GetTeam2Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x11218CA0);
                }

                /// <summary>
                /// Get the score of the current user.
                /// </summary>
                /// <returns>the user's score</returns>
                public int GetMyScore()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the bonus of the current user.
                /// </summary>
                /// <returns>the user's bonus</returns>
                public int GetMyBonus()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the kills of the current user.
                /// </summary>
                /// <returns>the user's kills</returns>
                public int GetMyKills()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }
            }

            public class CaptureTheFlag
            {
                private readonly Titanfall2Api _tf2Api;

                public CaptureTheFlag(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }

                /// <summary>
                /// Get the score of team 1. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 1</returns>
                public int GetTeam1Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x1121814C);
                }

                /// <summary>
                /// Get the score of team 2. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 2</returns>
                public int GetTeam2Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x11218CA0);
                }
            }

            public class LastTitanStanding
            {
                private readonly Titanfall2Api _tf2Api;

                public LastTitanStanding(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }
            }

            public class PilotsVersusPilots
            {
                private readonly Titanfall2Api _tf2Api;

                public PilotsVersusPilots(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }
            }

            public class LiveFire
            {
                private readonly Titanfall2Api _tf2Api;

                public LiveFire(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }
            }

            public class MarkedForDeath
            {
                private readonly Titanfall2Api _tf2Api;

                public MarkedForDeath(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }
            }

            public class TitanBrawl
            {
                private readonly Titanfall2Api _tf2Api;

                public TitanBrawl(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }

                /// <summary>
                /// Get the score of team 1. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 1</returns>
                public int GetTeam1Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x1121814C);
                }

                /// <summary>
                /// Get the score of team 2. Whether this is your team or the enemy's doesn't always stay the same.
                /// I'm not sure why. This is something that I need some help figuring out.
                /// </summary>
                /// <returns>the score of team 2</returns>
                public int GetTeam2Score()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._engineDllBaseAddress + 0x11218CA0);
                }

                /// <summary>
                /// Gets the round number (out of 5) of the current match.
                ///
                /// Candidates for this value are the following offsets:
                /// client.dll+FB83BC
                /// client.dll+FB83E4
                /// client.dll+FB840C
                ///
                /// If one of these is returning an erroneous result, the offset used by this method might need
                /// to be replaced with another one of these offsets.
                /// </summary>
                /// <returns>the current round number of the match</returns>
                public int GetRoundNumber()
                {
                    return _tf2Api._sharp!.Memory.Read<int>(_tf2Api._clientDllBaseAddress + 0xFB83BC);
                }

                /// <summary>
                /// Get the kills of the current user.
                /// </summary>
                /// <returns>the user's number of kills</returns>
                public int GetMyKills()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the deaths of the current user.
                /// </summary>
                /// <returns>the user's number of deaths</returns>
                public int GetMyDeaths()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }

                /// <summary>
                /// Get the titan damage of the current user.
                /// </summary>
                /// <returns>the amount of titan damage the current user has inflicted</returns>
                public int GetMyTitanDamage()
                {
                    throw new NotImplementedException(HelpMeBruh);
                }
            }

            public class FrontierDefense
            {
                private readonly Titanfall2Api _tf2Api;

                public FrontierDefense(Titanfall2Api tf2Api)
                {
                    _tf2Api = tf2Api;
                }
            }

            public Coliseum GetColiseum()
            {
                return _coliseum;
            }

            public Attrition GetAttrition()
            {
                return _attrition;
            }

            public Skirmish GetSkirmish()
            {
                return _skirmish;
            }

            public AmpedHardpoint GetAmpedHardpoint()
            {
                return _ampedHardpoint;
            }

            public BountyHunt GetBountyHunt()
            {
                return _bountyHunt;
            }

            public CaptureTheFlag GetCaptureTheFlag()
            {
                return _captureTheFlag;
            }

            public LastTitanStanding GetLastTitanStanding()
            {
                return _lastTitanStanding;
            }

            public PilotsVersusPilots GetPilotsVersusPilots()
            {
                return _pilotsVersusPilots;
            }

            public LiveFire GetLiveFire()
            {
                return _liveFire;
            }

            public MarkedForDeath GetMarkedForDeath()
            {
                return _markedForDeath;
            }

            public TitanBrawl GetTitanBrawl()
            {
                return _titanBrawl;
            }

            public FrontierDefense GetFrontierDefense()
            {
                return _frontierDefense;
            }
            

            /// <summary>
            /// Determine whether the user is searching for match or just sitting in a lobby.
            ///
            /// Some offsets that correspond to this behavior (lots of these may be wrong. This is just the list
            /// I whittled down after a lot of address scanning)
            /// client.dll+B221E1
            /// client.dll+B221E1
            /// client.dll+B221E2
            /// client.dll+B221E5
            /// client.dll+B221EE
            /// client.dll+B221F5
            /// client.dll+B221F5
            /// client.dll+B221F6
            /// client.dll+B221F6
            /// client.dll+B22221
            /// client.dll+B22221
            /// client.dll+B22222
            /// client.dll+B22225
            /// client.dll+B2222E
            /// client.dll+B22235
            /// client.dll+B22235
            /// client.dll+B22236
            /// client.dll+B22236
            /// client.dll+B2223E
            /// client.dll+BFCAA8
            /// client.dll+BFCAA8
            /// client.dll+BFCAA9
            /// client.dll+BFCAA9
            /// client.dll+11FC2C6
            /// client.dll+11FC2CA
            /// client.dll+11FC2CA
            /// client.dll+11FC2D4
            /// client.dll+11FC2D6
            /// client.dll+11FC2D6
            /// client.dll+11FC2DA
            /// client.dll+11FC2E9
            /// client.dll+11FC2E9
            /// client.dll+11FC2E9
            /// client.dll+11FC2EA
            /// client.dll+11FC35C
            /// client.dll+11FC39A
            /// client.dll+11FC3A3
            /// client.dll+11FC3A8
            /// client.dll+11FC7A4
            /// client.dll+11FC7A6
            /// client.dll+11FCBA1
            /// client.dll+11FCBC1
            /// client.dll+11FCBC2
            /// client.dll+11FCBC3
            /// client.dll+11FCBC6
            /// client.dll+11FCBC7
            /// client.dll+11FCBC9
            /// client.dll+11FCBCA
            /// client.dll+11FCBCB
            /// client.dll+11FCBCC
            /// client.dll+11FCBD2
            /// client.dll+11FCBDA
            /// client.dll+11FCBE4
            /// client.dll+11FCBEB
            /// client.dll+11FDBA2
            /// client.dll+11FDBA6
            /// client.dll+11FDBB1
            /// client.dll+11FDBB7
            /// client.dll+11FDBC5
            /// client.dll+11FDBC9
            /// client.dll+11FDBC9
            /// client.dll+11FDBD1
            /// client.dll+11FDBD1
            /// client.dll+11FDBD2
            /// client.dll+11FDBD6
            /// client.dll+1200C32
            /// client.dll+1200C32
            /// client.dll+1200C36
            /// client.dll+1200C36
            /// client.dll+1200C36
            /// client.dll+1200C39
            /// client.dll+1200C42
            /// client.dll+1200C42
            /// client.dll+1200C46
            /// client.dll+1200C49
            /// client.dll+1200C52
            /// client.dll+1200C59
            /// client.dll+1200C61
            /// client.dll+1200C62
            /// client.dll+1200C62
            /// client.dll+1200C62
            /// client.dll+1200C62
            /// client.dll+1200C65
            /// client.dll+1200C65
            /// client.dll+1200C65
            /// client.dll+1200C66
            /// client.dll+1300CE6
            /// client.dll+1300CEA
            /// client.dll+1300CF2
            /// client.dll+1300CF9
            /// client.dll+1300CF9
            /// client.dll+1300CF9
            /// client.dll+1300CFA
            /// client.dll+1300D06
            /// client.dll+1300D13
            /// client.dll+1380CE2
            /// client.dll+1380CE2
            /// client.dll+1380CE6
            /// client.dll+1380CE9
            /// client.dll+1380CF2
            /// client.dll+1380CF2
            /// client.dll+1380D02
            /// client.dll+1380D11
            /// client.dll+1380D12
            /// client.dll+1380D12
            /// client.dll+1380D12
            /// client.dll+1380D12
            /// client.dll+1380D15
            /// client.dll+1380D15
            /// client.dll+1380D62
            /// client.dll+1380D62
            /// client.dll+1380D66
            /// client.dll+1380D69
            /// client.dll+1380D72
            /// client.dll+1380D72
            /// client.dll+1380D82
            /// client.dll+1380D91
            /// client.dll+1380D92
            /// client.dll+1380D92
            /// client.dll+1380D92
            /// client.dll+1380D92
            /// client.dll+1380D95
            /// client.dll+1380D95
            /// client.dll+1380DCB
            /// client.dll+1380DE2
            /// client.dll+1380DE2
            /// client.dll+1380DF1
            /// client.dll+1380DF1
            /// client.dll+1380DF2
            /// client.dll+1380DF6
            /// client.dll+1380DF9
            /// client.dll+1380E02
            /// client.dll+1380E11
            /// client.dll+1380E12
            /// client.dll+1380E12
            /// client.dll+1380E12
            /// client.dll+1380E12
            /// client.dll+1380E15
            /// client.dll+1380E16
            /// client.dll+1380E20
            /// client.dll+1380E22
            /// client.dll+1380E23
            /// client.dll+1380E24
            /// client.dll+1380E25
            /// client.dll+1380E27
            /// client.dll+1380E29
            /// client.dll+1380E2B
            /// client.dll+1380E2C
            /// client.dll+1380E4F
            /// client.dll+1380E50
            /// client.dll+1380E54
            /// client.dll+1380E56
            /// client.dll+1380E62
            /// client.dll+1380E62
            /// client.dll+1380E71
            /// client.dll+1380E72
            /// client.dll+1380E77
            /// client.dll+1380E85
            /// client.dll+1380E91
            /// client.dll+1380E91
            /// client.dll+1380EE5
            /// client.dll+1380EF2
            /// client.dll+1380EFA
            /// client.dll+1E4917C
            /// client.dll+1E4917C
            /// client.dll+1E4917C
            /// client.dll+1E4917C
            /// client.dll+1E4917C
            /// client.dll+1E4917D
            /// client.dll+1E4917D
            /// client.dll+1E4917D
            /// client.dll+1E4917D
            /// client.dll+1E4917D
            /// client.dll+1E4917D
            /// client.dll+1E4917D
            /// client.dll+1E4917D
            /// client.dll+1E4917E
            /// client.dll+1E4917E
            /// client.dll+1E4917E
            /// client.dll+1E4917E
            /// client.dll+1E4917E
            /// client.dll+1E4917E
            /// client.dll+1E4917E
            /// client.dll+1E4917E
            /// client.dll+1E4917F
            /// client.dll+1E4917F
            /// client.dll+1E4917F
            /// client.dll+1E4917F
            /// client.dll+1E4917F
            /// client.dll+1E4917F
            /// client.dll+1E4917F
            /// client.dll+1E4917F
            /// client.dll+1E49194
            /// client.dll+1E511A4
            /// client.dll+1E511B0
            /// client.dll+1E511B0
            /// client.dll+1E61179
            /// client.dll+1E61187
            /// client.dll+1E61193
            /// client.dll+1E61195
            /// client.dll+1E61197
            /// client.dll+1E61199
            /// client.dll+1E6119B
            /// client.dll+1E6119C
            /// client.dll+1E611A1
            /// client.dll+1E611A2
            /// client.dll+1E611A2
            /// client.dll+1E611A6
            /// client.dll+1E611A6
            /// client.dll+1E611B3
            /// client.dll+1E611C2
            /// client.dll+1E611C5
            /// client.dll+1E611C5
            /// client.dll+1E611C6
            /// client.dll+1E611D1
            /// client.dll+1E611D1
            /// client.dll+1E611D2
            /// client.dll+1E611E3
            /// client.dll+1E611E5
            /// client.dll+1E611E5
            /// client.dll+1E611E7
            /// client.dll+1E611EB
            /// client.dll+1E611EC
            /// client.dll+1E61202
            /// client.dll+1E61216
            /// client.dll+1E6121A
            /// client.dll+1E74180
            /// client.dll+1E74180
            /// client.dll+1E74180
            /// client.dll+1E74180
            /// client.dll+1E74180
            /// client.dll+1E74180
            /// client.dll+1E74180
            /// client.dll+1E74180
            /// client.dll+1E74184
            /// client.dll+1E74185
            /// client.dll+1E74185
            /// client.dll+1E74185
            /// client.dll+1E74185
            /// client.dll+1E74185
            /// client.dll+216FD19
            /// client.dll+216FD1A
            /// client.dll+216FD1A
            /// client.dll+216FD1A
            /// client.dll+216FD1A
            /// client.dll+2173D9C
            /// client.dll+2173D9C
            /// client.dll+2173D9D
            /// client.dll+2173D9D
            /// client.dll+2173DA1
            /// client.dll+2173DA1
            /// client.dll+2215102
            /// client.dll+2215102
            /// client.dll+2215114
            /// client.dll+221514E
            /// client.dll+22151C2
            /// client.dll+22151C2
            /// client.dll+22151D4
            /// client.dll+2215200
            /// client.dll+2215200
            /// client.dll+2215201
            /// client.dll+2215201
            /// client.dll+2215204
            /// client.dll+2215204
            /// client.dll+2215204
            /// client.dll+2215205
            /// client.dll+2215206
            /// client.dll+2215206
            /// client.dll+221522C
            /// client.dll+221522C
            /// client.dll+221522C
            /// client.dll+221522D
            /// client.dll+221522E
            /// client.dll+221522E
            /// client.dll+221522E
            /// client.dll+221522E
            /// client.dll+22A2A02
            /// client.dll+22A2A02
            /// client.dll+22A2A14
            /// client.dll+22A2A4E
            /// client.dll+22A2AC2
            /// client.dll+22A2AC2
            /// client.dll+22A2AD4
            /// client.dll+22A2B00
            /// client.dll+22A2B00
            /// client.dll+22A2B01
            /// client.dll+22A2B01
            /// client.dll+22A2B04
            /// client.dll+22A2B04
            /// client.dll+22A2B04
            /// client.dll+22A2B05
            /// client.dll+22A2B06
            /// client.dll+22A2B06
            /// client.dll+22A2B2C
            /// client.dll+22A2B2C
            /// client.dll+22A2B2C
            /// client.dll+22A2B2D
            /// client.dll+22A2B2E
            /// client.dll+22A2B2E
            /// client.dll+22A2B2E
            /// client.dll+22A2B2E
            /// client.dll+22A2B45
            /// client.dll+22A2B45
            /// client.dll+22A2BD1
            /// client.dll+22A2BD1
            /// client.dll+22A2BD2
            /// client.dll+22A2BD5
            /// client.dll+22A2BDE
            /// client.dll+22A2BE5
            /// client.dll+22A2BE5
            /// client.dll+22A2BE6
            /// client.dll+22A2BE6
            /// client.dll+22A2C11
            /// client.dll+22A2C11
            /// client.dll+22A2C12
            /// client.dll+22A2C15
            /// client.dll+22A2C1E
            /// client.dll+22A2C25
            /// client.dll+22A2C25
            /// client.dll+22A2C26
            /// client.dll+22A2C26
            /// client.dll+22A2C2E
            /// client.dll+22A2DDE
            /// client.dll+2E55F96
            /// client.dll+2E55F9E
            /// client.dll+2E55F9E
            /// client.dll+2E55F9E
            /// client.dll+2E55FA6
            /// client.dll+2E55FA6
            /// client.dll+2E55FA9
            /// client.dll+2E55FAA
            /// client.dll+2E55FAA
            /// client.dll+2E55FAA
            /// client.dll+2E55FAD
            /// client.dll+2E55FB1
            /// client.dll+2E55FB1
            /// client.dll+2E55FB2
            /// client.dll+2E55FB5
            /// client.dll+2E55FB5
            /// client.dll+2E55FB6
            /// client.dll+2E55FB9
            /// client.dll+2E55FBA
            /// client.dll+2E55FBD
            /// client.dll+2E55FC0
            /// client.dll+2E55FC1
            /// 
            /// AS WELL AS
            /// 
            /// engine.dll+8A9D68
            /// engine.dll+8A9D68
            /// engine.dll+8A9D69
            /// engine.dll+8A9D69
            /// engine.dll+8A9D69
            /// engine.dll+8A9D69
            /// engine.dll+8A9D6A
            /// engine.dll+8A9D6A
            /// engine.dll+8A9D6A
            /// engine.dll+8A9D6A
            /// engine.dll+8A9D6B
            /// engine.dll+8A9D6B
            /// engine.dll+8A9D6B
            /// engine.dll+8A9D6C
            /// engine.dll+8AA1BA
            /// engine.dll+8AA1BB
            /// engine.dll+8AA1BB
            /// engine.dll+8AA1BB
            /// engine.dll+8AA1BB
            /// engine.dll+8AA1BB
            /// engine.dll+8AA1BB
            /// engine.dll+8AA1BC
            /// engine.dll+12A26810
            /// engine.dll+12A26828
            /// engine.dll+12A2684A
            /// engine.dll+12A26861
            /// engine.dll+12A2686B
            /// engine.dll+12A26872
            /// engine.dll+12A26872
            /// engine.dll+12A26873
            /// engine.dll+12A26873
            /// engine.dll+12A2688A
            /// engine.dll+12A2688B
            /// engine.dll+12A26891
            /// engine.dll+12A26899
            /// engine.dll+12A26899
            /// engine.dll+12A2689A
            /// engine.dll+12A268A1
            /// engine.dll+12A268A2
            /// engine.dll+12A268AA
            /// engine.dll+12A268B0
            /// engine.dll+12A268BA
            /// engine.dll+12A268C1
            /// engine.dll+12A268C2
            /// engine.dll+12A268D2
            /// engine.dll+12A268DB
            /// engine.dll+12A268E1
            /// engine.dll+12A268E3
            /// engine.dll+12A268E9
            /// engine.dll+12A268EA
            /// engine.dll+12A26900
            /// engine.dll+12A26AEC
            /// engine.dll+12A2A690
            /// engine.dll+12A2A6A8
            /// engine.dll+12A2A6CA
            /// engine.dll+12A2A6E1
            /// engine.dll+12A2A6EB
            /// engine.dll+12A2A6F2
            /// engine.dll+12A2A6F2
            /// engine.dll+12A2A6F3
            /// engine.dll+12A2A6F3
            /// engine.dll+12A2A70A
            /// engine.dll+12A2A70B
            /// engine.dll+12A2A711
            /// engine.dll+12A2A719
            /// engine.dll+12A2A719
            /// engine.dll+12A2A71A
            /// engine.dll+12A2A721
            /// engine.dll+12A2A722
            /// engine.dll+12A2A72A
            /// engine.dll+12A2A730
            /// engine.dll+12A2A73A
            /// engine.dll+12A2A741
            /// engine.dll+12A2A742
            /// engine.dll+12A2A752
            /// engine.dll+12A2A75B
            /// engine.dll+12A2A761
            /// engine.dll+12A2A763
            /// engine.dll+12A2A769
            /// engine.dll+12A2A76A
            /// engine.dll+12A2A780
            /// engine.dll+12A2A96C
            /// engine.dll+130D9AFE
            /// engine.dll+130D9AFE
            /// engine.dll+130D9AFE
            /// engine.dll+130D9B00
            /// </summary>
            /// <returns></returns>
            public bool IsSearchingForMatch()
            {
                // TODO: There are duplicates in the pointers list above (somehow)
                return _tf2Api._sharp!.Memory.Read(_tf2Api._clientDllBaseAddress + 0xB221E1, 1)[0]==1;
            }

            public Faction GetCurrentFaction()
            {
                return FactionMethods.GetFaction(
                    _tf2Api._sharp!.Memory.Read(_tf2Api._engineDllBaseAddress + 0x7A7383, 1)[0]);
            }
        }
    }
}