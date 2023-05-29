// See https://aka.ms/new-console-template for more information
using DiscoverRecords;

var positionC = new PositionC(1, 1);
var positionC2 = positionC;
positionC2.X = 2;

Console.WriteLine($"1: {positionC.X} / 2: {positionC2.X}, ?: {positionC == positionC2}");


var positionS = new PositionS(1, 1);
var positionS2 = positionS;
positionS2.X = 2;

Console.WriteLine($"1: {positionS.X} / 2: {positionS2.X}, ?: {positionS.Equals(positionS2)}");


var positionR = new PositionR(1, 1);
var positionR2 = positionR;
// positionR2.X = 2; // On ne peut pas changer

Console.WriteLine($"1: {positionR.X} / 2: {positionR2.X}, ?: {positionR == positionR2}");


//var positionRC = new PositionRC(1, 1);
var positionRC = new PositionRC() { X = 1, Y = 1 };
var positionRC2 = positionRC;
//positionRC2.X = 2; // On ne peut pas changer
positionRC2.X = 2; 

Console.WriteLine($"1: {positionRC.X} / 2: {positionRC2.X}, ?: {positionRC == positionRC2}");


//var positionRS = new PositionRS(1, 1);
var positionRS = new PositionRS() { X = 1, Y = 1 };
var positionRS2 = positionRS;
//positionRS2.X = 2; // On ne peut pas changer
positionRS2.X = 2; 

Console.WriteLine($"1: {positionRS.X} / 2: {positionRS2.X}, ?: {positionRS == positionRS2}");
