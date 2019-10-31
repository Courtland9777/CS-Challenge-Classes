//Count IP Addresses


public static long IpsBetween(string start, string end)
{
    return (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(end).Address) - 
        (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(start).Address);
}