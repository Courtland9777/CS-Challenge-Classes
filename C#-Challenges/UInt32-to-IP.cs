//Convert UInt32 to IPv4

public static IPAddress UInt32ToIP(uint address)
{
    return new IPAddress(new byte[] { 
        (byte)((address>>24) & 0xFF) ,
        (byte)((address>>16) & 0xFF) , 
        (byte)((address>>8)  & 0xFF) , 
        (byte)( address & 0xFF)});
}