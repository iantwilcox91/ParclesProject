namespace Parcels.Objects
{
  public class Parcel
  {
    private int _numberLength;
    private int _numberWidth;
    private int _numberHeight;
    private int _numberWeight;
    private int _numberVolume;
    // private int _numberCost;


    public int GetnumberLength()
    {
      return _numberLength;
    }
    public void SetnumberLength(int newNumberLength)
    {
      _numberLength = newNumberLength;
    }
    public int GetnumberWidth()
    {
      return _numberWidth;
    }
    public void SetnumberWidth(int newNumberWidth)
    {
      _numberWidth = newNumberWidth;
    }
    public int GetnumberHeight()
    {
      return _numberHeight;
    }
    public void SetnumberHeight(int newNumberHeight)
    {
      _numberHeight = newNumberHeight;
    }
    public int GetnumberWeight()
    {
      return _numberWeight;
    }
    public void SetnumberWeight(int newNumberWeight)
    {
      _numberWeight = newNumberWeight;
    }
    public int GetnumberVolume()
    {
      return _numberVolume;
    }
    public void SetnumberVolume()
    {
      _numberVolume = _numberLength * _numberWidth * _numberHeight;
    }






  }
}
