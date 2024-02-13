using System;

public static  class konvert
{
    // To json "\r\n", "\\r\\n"
    public static  string enbreak(string value)
    {
        if (string.IsNullOrEmpty(value))
            return string.Empty;

        value = value.Replace("\r", "\\r");
        value = value.Replace("\n", "\\n");
        value = value.Replace("\r\n", "\\r\\n");
        return value;
    }
    public static  string covert(object value)
    {
        return covert(value, string.Empty);
    }
    public static  string covert(object value, string defaultValue)
    {
        try
        {

            return (value == null) ? defaultValue : System.Convert.ToString(value);
        }
        catch
        {
            return string.Empty;
        }
    }


    public static  Boolean boolean(object objBoolean, Boolean defaultValue)
    {
        if (objBoolean == null)
            return defaultValue;

        try
        {
            return System.Convert.ToBoolean(objBoolean);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static  Boolean boolean(object objBoolean)
    {
        return boolean(objBoolean, false);
    }

    public static  Byte biter(object objByte, Byte defaultValue)
    {
        if (objByte == null)
            return defaultValue;

        try
        {
            return System.Convert.ToByte(objByte);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static Byte biter(object objByte)
    {
        return biter(objByte, 0);
    }

    public static  Int16 shorter(object objInt16, Int16 defaultValue)
    {
        if (objInt16 == null)
            return defaultValue;

        try
        {
            return System.Convert.ToInt16(objInt16);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static Int16 shorter(object objInt16)
    {
        return shorter(objInt16, 0);
    }

    public static  Int32 integer(object objInt32, Int32 defaultValue)
    {
        if (objInt32 == null)
            return defaultValue;

        try
        {
            return System.Convert.ToInt32(objInt32);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static Int32 integer(object objInt32)
    {
        return integer(objInt32, 0);
    }

    public static  Int64 longer(object objInt64, Int64 defaultValue)
    {
        if (objInt64 == null)
            return defaultValue;

        try
        {
            return System.Convert.ToInt64(objInt64);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static Int64 longer(object objInt64)
    {
        return longer(objInt64, 0);
    }

    public static Decimal decimals(object objDecimal, Decimal defaultValue)
    {
        if (objDecimal == null)
            return defaultValue;

        try
        {
            return System.Convert.ToDecimal(objDecimal);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static  Decimal decimals(object objDecimal)
    {
        return decimals(objDecimal, 0.00M);
    }

    public static DateTime date_time(object objDateTime, DateTime defaultValue)
    {
        if (objDateTime == null)
            return defaultValue;

        try
        {
            return System.Convert.ToDateTime(objDateTime);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static  DateTime date_time(object objDateTime)
    {
        return date_time(objDateTime, DateTime.Now);
    }
    public static  string time_string(object objDateTime)
    {
        return date_time(objDateTime, DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss:fff");
    }
    public static  string currency(object objDecimal, Decimal defaultValue)
    {
        return decimals(objDecimal, defaultValue).ToString("F");
    }

    public static string currency(object objDecimal)
    {
        return decimals(objDecimal).ToString("C");
    }
}
