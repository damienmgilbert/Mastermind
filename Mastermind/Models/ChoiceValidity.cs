using System;
using System.Linq;

namespace Mastermind.Models;

public enum ChoiceValidity
{
    NotPresent,
    Present,
    PresentAndInPosition
}

public enum PieceChoice
{
    None,
    Red,
    Blue,
    Green,
    Orange,
    Purple,
    Brown,
    Gray,
    Pink,
    Yellow
}