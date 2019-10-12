//For building the encrypted string:
//Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
//Do this n times!

//Examples:

//"This is a test!", 1 -> "hsi  etTi sats!"
//"This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"

using System.Linq;

public class Challenge
{
  public static string Encrypt(string text, int n)
  {
    if (text==null) return text;
    while(n-->0){
      text=string.Join("",text.Where((x,i)=>i%2==1))+string.Join("",text.Where((x,i)=>i%2==0));
    }
    return s;
  }
  
  public static string Decrypt(string encryptedText, int n)
  {
    if (encryptedText==null) return encryptedText;
    while(n-->0){
      var len=encryptedText.Length/2;
      string s1=encryptedText.Substring(0,len);
	  string s2=encryptedText.Substring(len);
	  string rs="";
      for (int i=0;i<len;i++) rs+=""+s2[i]+s1[i];
      encryptedText=(encryptedText.Length%2==0)?rs:rs+s[encryptedText.Length-1];
    }
    return s;
  }
}