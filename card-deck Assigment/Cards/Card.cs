using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace card_deck_assignment.Cards
{
    public enum CColor { Red, Black }
    public enum CType { Heart, Diamond, Clover, Spade }

    public enum CValue { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten ,Jack ,Queen, King }
    public class Card : IComparable<Card>
    {
        public CColor mColor;
        public CType mType;
        public CValue mValue;
        public String mImage;
        public Card(CType type, CValue value)
        {
            mColor = GetTColor(type);
            mType = type;
            mValue = value;
            mImage = getTImage(type, value);
        }

        //returns the name for the image based on value and type
        private string getTImage(CType type, CValue value)
        {
            String name = "";

            if ((int)value < 10)
            {
                int vv = (int)value + 1;
                name += vv;
            }
            else
            {
                switch (value)
                {
                    case CValue.Jack:
                        name += "J";
                        break;
                    case CValue.Queen:
                        name += "Q";
                        break;
                    case CValue.King:
                        name += "K";
                        break;
                    default:
                        break;
                }
            }

            switch (type)
            {
                case CType.Diamond:
                    name += "D";
                    break;
                case CType.Clover:
                    name += "C";
                    break;
                case CType.Heart:
                    name += "H";
                    break;
                case CType.Spade:
                    name += "S";
                    break;
            }
            return name;
        }

        //sorting Compare
        public int CompareTo(Card other)
        {
            //Sort after color then type then value
            if (mColor > other.mColor) return 1;
            if (mColor < other.mColor) return -1;
            if( mType > other.mType ) return 1;
            if( mType < other.mType ) return -1;
            if(mValue > other.mValue) return 1;
            return -1;
        }

        public CColor GetTColor(CType type)
        {
            switch(type)
            {
                case CType.Heart:
                    return CColor.Red;
                case CType.Diamond:
                    return CColor.Red;
                case CType.Clover:
                    return CColor.Black;
                case CType.Spade:
                    return CColor.Black;
                default:
                    throw new Exception("Invalid Card Type");
            }
        }
    }
}
