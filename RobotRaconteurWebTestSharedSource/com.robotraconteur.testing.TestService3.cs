//This file is automatically generated. DO NOT EDIT!
using System;
using RobotRaconteurWeb;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 0108

namespace com.robotraconteur.testing.TestService3
{
[RobotRaconteurServiceStruct("com.robotraconteur.testing.TestService3.teststruct3")]
public class teststruct3
{
    public testpod1 s1;
    public testpod1[] s2;
    public testpod1[] s3;
    public testpod1[] s4;
    public PodMultiDimArray s5;
    public PodMultiDimArray s6;
    public List<testpod1> s7;
    public List<testpod1[]> s8;
    public List<PodMultiDimArray> s9;
    public object s10;
    public object s11;
    public object s12;
    public object s13;
    public object s14;
    public object s15;
    public transform t1;
    public transform[] t2;
    public NamedMultiDimArray t3;
    public object t4;
    public object t5;
    public List<transform> t6;
    public List<transform[]> t7;
    public List<NamedMultiDimArray> t8;
    public object t9;
    public object t10;
    public object t11;
}

[RobotRaconteurNamedArrayElementTypeAndCount("com.robotraconteur.testing.TestService3.vector3",typeof(double), 3)]
public struct vector3
{
    public double x;
    public double y;
    public double z;
    public double[] GetNumericArray()
    {
    var a=new ArraySegment<double>(new double[3]);
    GetNumericArray(ref a);
    return a.Array;
    }
    public void GetNumericArray(ref ArraySegment<double> a)
    {
    if(a.Count < 3) throw new ArgumentException("ArraySegment invalid length");
    a.Array[a.Offset + 0] = x;
    a.Array[a.Offset + 1] = y;
    a.Array[a.Offset + 2] = z;
    }
    public void AssignFromNumericArray(ref ArraySegment<double> a)
    {
    if(a.Count < 3) throw new ArgumentException("ArraySegment invalid length");
    x = a.Array[a.Offset + 0];
    y = a.Array[a.Offset + 1];
    z = a.Array[a.Offset + 2];
    }
}

[RobotRaconteurNamedArrayElementTypeAndCount("com.robotraconteur.testing.TestService3.quaternion",typeof(double), 4)]
public struct quaternion
{
    public double q0;
    public double q1;
    public double q2;
    public double q3;
    public double[] GetNumericArray()
    {
    var a=new ArraySegment<double>(new double[4]);
    GetNumericArray(ref a);
    return a.Array;
    }
    public void GetNumericArray(ref ArraySegment<double> a)
    {
    if(a.Count < 4) throw new ArgumentException("ArraySegment invalid length");
    a.Array[a.Offset + 0] = q0;
    a.Array[a.Offset + 1] = q1;
    a.Array[a.Offset + 2] = q2;
    a.Array[a.Offset + 3] = q3;
    }
    public void AssignFromNumericArray(ref ArraySegment<double> a)
    {
    if(a.Count < 4) throw new ArgumentException("ArraySegment invalid length");
    q0 = a.Array[a.Offset + 0];
    q1 = a.Array[a.Offset + 1];
    q2 = a.Array[a.Offset + 2];
    q3 = a.Array[a.Offset + 3];
    }
}

[RobotRaconteurNamedArrayElementTypeAndCount("com.robotraconteur.testing.TestService3.transform",typeof(double), 7)]
public struct transform
{
    public quaternion rotation;
    public vector3 translation;
    public double[] GetNumericArray()
    {
    var a=new ArraySegment<double>(new double[7]);
    GetNumericArray(ref a);
    return a.Array;
    }
    public void GetNumericArray(ref ArraySegment<double> a)
    {
    if(a.Count < 7) throw new ArgumentException("ArraySegment invalid length");
    var a0 = new ArraySegment<double>(a.Array, a.Offset + 0, 4);
    rotation.GetNumericArray(ref a0);
    var a4 = new ArraySegment<double>(a.Array, a.Offset + 4, 3);
    translation.GetNumericArray(ref a4);
    }
    public void AssignFromNumericArray(ref ArraySegment<double> a)
    {
    if(a.Count < 7) throw new ArgumentException("ArraySegment invalid length");
    var a0 = new ArraySegment<double>(a.Array, a.Offset + 0, 4);
    rotation.AssignFromNumericArray(ref a0);
    var a4 = new ArraySegment<double>(a.Array, a.Offset + 4, 3);
    translation.AssignFromNumericArray(ref a4);
    }
}

[RobotRaconteurNamedArrayElementTypeAndCount("com.robotraconteur.testing.TestService3.pixel",typeof(byte), 3)]
public struct pixel
{
    public byte r;
    public byte b;
    public byte g;
    public byte[] GetNumericArray()
    {
    var a=new ArraySegment<byte>(new byte[3]);
    GetNumericArray(ref a);
    return a.Array;
    }
    public void GetNumericArray(ref ArraySegment<byte> a)
    {
    if(a.Count < 3) throw new ArgumentException("ArraySegment invalid length");
    a.Array[a.Offset + 0] = r;
    a.Array[a.Offset + 1] = b;
    a.Array[a.Offset + 2] = g;
    }
    public void AssignFromNumericArray(ref ArraySegment<byte> a)
    {
    if(a.Count < 3) throw new ArgumentException("ArraySegment invalid length");
    r = a.Array[a.Offset + 0];
    b = a.Array[a.Offset + 1];
    g = a.Array[a.Offset + 2];
    }
}

[RobotRaconteurNamedArrayElementTypeAndCount("com.robotraconteur.testing.TestService3.pixel2",typeof(byte), 31)]
public struct pixel2
{
    public byte c;
    public pixel d;
    public pixel e;
    public pixel[] f;
    public pixel g;
    public byte[] GetNumericArray()
    {
    var a=new ArraySegment<byte>(new byte[31]);
    GetNumericArray(ref a);
    return a.Array;
    }
    public void GetNumericArray(ref ArraySegment<byte> a)
    {
    if(a.Count < 31) throw new ArgumentException("ArraySegment invalid length");
    a.Array[a.Offset + 0] = c;
    var a1 = new ArraySegment<byte>(a.Array, a.Offset + 1, 3);
    d.GetNumericArray(ref a1);
    var a4 = new ArraySegment<byte>(a.Array, a.Offset + 4, 3);
    e.GetNumericArray(ref a4);
    var a7 = new ArraySegment<byte>(a.Array, a.Offset + 7, 21);
    f.GetNumericArray(ref a7);
    var a28 = new ArraySegment<byte>(a.Array, a.Offset + 28, 3);
    g.GetNumericArray(ref a28);
    }
    public void AssignFromNumericArray(ref ArraySegment<byte> a)
    {
    if(a.Count < 31) throw new ArgumentException("ArraySegment invalid length");
    c = a.Array[a.Offset + 0];
    var a1 = new ArraySegment<byte>(a.Array, a.Offset + 1, 3);
    d.AssignFromNumericArray(ref a1);
    var a4 = new ArraySegment<byte>(a.Array, a.Offset + 4, 3);
    e.AssignFromNumericArray(ref a4);
    var a7 = new ArraySegment<byte>(a.Array, a.Offset + 7, 21);
    f.AssignFromNumericArray(ref a7);
    var a28 = new ArraySegment<byte>(a.Array, a.Offset + 28, 3);
    g.AssignFromNumericArray(ref a28);
    }
}

[RobotRaconteurServicePod("com.robotraconteur.testing.TestService3.testpod1")]
public struct testpod1
{
    public double d1;
    public double[] d2;
    public double[] d3;
    public double[] d4;
    public testpod2 s1;
    public testpod2[] s2;
    public testpod2[] s3;
    public testpod2[] s4;
    public transform t1;
    public transform[] t2;
    public transform[] t3;
    public transform[] t4;
}

[RobotRaconteurServicePod("com.robotraconteur.testing.TestService3.testpod2")]
public struct testpod2
{
    public sbyte i1;
    public sbyte[] i2;
    public sbyte[] i3;
}

[RobotRaconteurServiceObjectInterface("com.robotraconteur.testing.TestService3.testroot3")]
public interface testroot3
{
    Task<int> get_readme(CancellationToken cancel=default(CancellationToken));
    Task set_readme(int value, CancellationToken cancel=default(CancellationToken));
    Task<int> get_writeme(CancellationToken cancel=default(CancellationToken));
    Task set_writeme(int value, CancellationToken cancel=default(CancellationToken));
    Task<int> get_unknown_modifier(CancellationToken cancel=default(CancellationToken));
    Task set_unknown_modifier(int value, CancellationToken cancel=default(CancellationToken));
    Task<testenum1> get_testenum1_prop(CancellationToken cancel=default(CancellationToken));
    Task set_testenum1_prop(testenum1 value, CancellationToken cancel=default(CancellationToken));
    Task<testpod1> get_testpod1_prop(CancellationToken cancel=default(CancellationToken));
    Task set_testpod1_prop(testpod1 value, CancellationToken cancel=default(CancellationToken));
    Task<teststruct3> get_teststruct3_prop(CancellationToken cancel=default(CancellationToken));
    Task set_teststruct3_prop(teststruct3 value, CancellationToken cancel=default(CancellationToken));
    Task<List<double[]>> get_d1(CancellationToken cancel=default(CancellationToken));
    Task set_d1(List<double[]> value, CancellationToken cancel=default(CancellationToken));
    Task<List<double[]>> get_d2(CancellationToken cancel=default(CancellationToken));
    Task set_d2(List<double[]> value, CancellationToken cancel=default(CancellationToken));
    Task<Dictionary<int,double[]>> get_d3(CancellationToken cancel=default(CancellationToken));
    Task set_d3(Dictionary<int,double[]> value, CancellationToken cancel=default(CancellationToken));
    Task<Dictionary<int,double[]>> get_d4(CancellationToken cancel=default(CancellationToken));
    Task set_d4(Dictionary<int,double[]> value, CancellationToken cancel=default(CancellationToken));
    Task<List<MultiDimArray>> get_d5(CancellationToken cancel=default(CancellationToken));
    Task set_d5(List<MultiDimArray> value, CancellationToken cancel=default(CancellationToken));
    Task<Dictionary<int,MultiDimArray>> get_d6(CancellationToken cancel=default(CancellationToken));
    Task set_d6(Dictionary<int,MultiDimArray> value, CancellationToken cancel=default(CancellationToken));
    Task<vector3> get_testnamedarray1(CancellationToken cancel=default(CancellationToken));
    Task set_testnamedarray1(vector3 value, CancellationToken cancel=default(CancellationToken));
    Task<transform> get_testnamedarray2(CancellationToken cancel=default(CancellationToken));
    Task set_testnamedarray2(transform value, CancellationToken cancel=default(CancellationToken));
    Task<transform[]> get_testnamedarray3(CancellationToken cancel=default(CancellationToken));
    Task set_testnamedarray3(transform[] value, CancellationToken cancel=default(CancellationToken));
    Task<NamedMultiDimArray> get_testnamedarray4(CancellationToken cancel=default(CancellationToken));
    Task set_testnamedarray4(NamedMultiDimArray value, CancellationToken cancel=default(CancellationToken));
    Task<NamedMultiDimArray> get_testnamedarray5(CancellationToken cancel=default(CancellationToken));
    Task set_testnamedarray5(NamedMultiDimArray value, CancellationToken cancel=default(CancellationToken));
    Task<CDouble> get_c1(CancellationToken cancel=default(CancellationToken));
    Task set_c1(CDouble value, CancellationToken cancel=default(CancellationToken));
    Task<CDouble[]> get_c2(CancellationToken cancel=default(CancellationToken));
    Task set_c2(CDouble[] value, CancellationToken cancel=default(CancellationToken));
    Task<MultiDimArray> get_c3(CancellationToken cancel=default(CancellationToken));
    Task set_c3(MultiDimArray value, CancellationToken cancel=default(CancellationToken));
    Task<List<CDouble>> get_c4(CancellationToken cancel=default(CancellationToken));
    Task set_c4(List<CDouble> value, CancellationToken cancel=default(CancellationToken));
    Task<List<CDouble[]>> get_c5(CancellationToken cancel=default(CancellationToken));
    Task set_c5(List<CDouble[]> value, CancellationToken cancel=default(CancellationToken));
    Task<List<MultiDimArray>> get_c6(CancellationToken cancel=default(CancellationToken));
    Task set_c6(List<MultiDimArray> value, CancellationToken cancel=default(CancellationToken));
    Task<CSingle> get_c7(CancellationToken cancel=default(CancellationToken));
    Task set_c7(CSingle value, CancellationToken cancel=default(CancellationToken));
    Task<CSingle[]> get_c8(CancellationToken cancel=default(CancellationToken));
    Task set_c8(CSingle[] value, CancellationToken cancel=default(CancellationToken));
    Task<MultiDimArray> get_c9(CancellationToken cancel=default(CancellationToken));
    Task set_c9(MultiDimArray value, CancellationToken cancel=default(CancellationToken));
    Task<List<CSingle>> get_c10(CancellationToken cancel=default(CancellationToken));
    Task set_c10(List<CSingle> value, CancellationToken cancel=default(CancellationToken));
    Task<List<CSingle[]>> get_c11(CancellationToken cancel=default(CancellationToken));
    Task set_c11(List<CSingle[]> value, CancellationToken cancel=default(CancellationToken));
    Task<List<MultiDimArray>> get_c12(CancellationToken cancel=default(CancellationToken));
    Task set_c12(List<MultiDimArray> value, CancellationToken cancel=default(CancellationToken));
    Task<bool> get_b1(CancellationToken cancel=default(CancellationToken));
    Task set_b1(bool value, CancellationToken cancel=default(CancellationToken));
    Task<bool[]> get_b2(CancellationToken cancel=default(CancellationToken));
    Task set_b2(bool[] value, CancellationToken cancel=default(CancellationToken));
    Task<MultiDimArray> get_b3(CancellationToken cancel=default(CancellationToken));
    Task set_b3(MultiDimArray value, CancellationToken cancel=default(CancellationToken));
    Task<List<bool>> get_b4(CancellationToken cancel=default(CancellationToken));
    Task set_b4(List<bool> value, CancellationToken cancel=default(CancellationToken));
    Task<List<bool[]>> get_b5(CancellationToken cancel=default(CancellationToken));
    Task set_b5(List<bool[]> value, CancellationToken cancel=default(CancellationToken));
    Task<List<MultiDimArray>> get_b6(CancellationToken cancel=default(CancellationToken));
    Task set_b6(List<MultiDimArray> value, CancellationToken cancel=default(CancellationToken));
    Task testpod1_func1(testpod1 s,CancellationToken rr_cancel=default(CancellationToken));
    Task<testpod1> testpod1_func2(CancellationToken rr_cancel=default(CancellationToken));
    Task<Generator2<double>> gen_func1(CancellationToken rr_cancel=default(CancellationToken));
    Task<Generator2<byte[]>> gen_func2(string name,CancellationToken rr_cancel=default(CancellationToken));
    Task<Generator3<byte[]>> gen_func3(string name,CancellationToken rr_cancel=default(CancellationToken));
    Task<Generator1<byte[],byte[]>> gen_func4(CancellationToken rr_cancel=default(CancellationToken));
    Task<Generator1<com.robotraconteur.testing.TestService1.teststruct2,com.robotraconteur.testing.TestService1.teststruct2>> gen_func5(CancellationToken rr_cancel=default(CancellationToken));
    Task<obj4> get_o4(CancellationToken rr_cancel=default(CancellationToken));
    Pipe<int> unreliable1{ get; set; }
    Pipe<int> unreliable2{ get; set; }
    Pipe<int[]> p1{ get; set; }
    Pipe<int[]> p2{ get; set; }
    Pipe<MultiDimArray> p3{ get; set; }
    Wire<int> peekwire { get; set; }
    Wire<int> pokewire { get; set; }
    Wire<int[]> w1 { get; set; }
    Wire<int[]> w2 { get; set; }
    Wire<MultiDimArray> w3 { get; set; }
    ArrayMemory<double> readmem { get; }
    PodArrayMemory<testpod2> pod_m1 { get; }
    PodMultiDimArrayMemory<testpod2> pod_m2 { get; }
    NamedArrayMemory<transform> namedarray_m1 { get; }
    NamedMultiDimArrayMemory<transform> namedarray_m2 { get; }
    ArrayMemory<CDouble> c_m1 { get; }
    MultiDimArrayMemory<CDouble> c_m2 { get; }
    ArrayMemory<CDouble> c_m3 { get; }
    MultiDimArrayMemory<CDouble> c_m4 { get; }
    ArrayMemory<bool> c_m5 { get; }
    MultiDimArrayMemory<bool> c_m6 { get; }
}

[RobotRaconteurServiceObjectInterface("com.robotraconteur.testing.TestService3.obj1")]
public interface obj1
{
    Task<double[]> get_d1(CancellationToken cancel=default(CancellationToken));
    Task set_d1(double[] value, CancellationToken cancel=default(CancellationToken));
}

[RobotRaconteurServiceObjectInterface("com.robotraconteur.testing.TestService3.obj2")]
public interface obj2 : obj1
{
    Task<double[]> get_d1(CancellationToken cancel=default(CancellationToken));
    Task set_d1(double[] value, CancellationToken cancel=default(CancellationToken));
}

[RobotRaconteurServiceObjectInterface("com.robotraconteur.testing.TestService3.obj3")]
public interface obj3 : obj1, obj2
{
    Task<double[]> get_d1(CancellationToken cancel=default(CancellationToken));
    Task set_d1(double[] value, CancellationToken cancel=default(CancellationToken));
}

[RobotRaconteurServiceObjectInterface("com.robotraconteur.testing.TestService3.obj4")]
public interface obj4 : com.robotraconteur.testing.TestService1.sub2
{
    Task<string> get_s_ind(CancellationToken cancel=default(CancellationToken));
    Task set_s_ind(string value, CancellationToken cancel=default(CancellationToken));
    Task<int> get_i_ind(CancellationToken cancel=default(CancellationToken));
    Task set_i_ind(int value, CancellationToken cancel=default(CancellationToken));
    Task<string> get_data(CancellationToken cancel=default(CancellationToken));
    Task set_data(string value, CancellationToken cancel=default(CancellationToken));
    Task<com.robotraconteur.testing.TestService1.sub3> get_o3_1(string ind, CancellationToken rr_cancel=default(CancellationToken));
}

public static class com__robotraconteur__testing__TestService3Constants  {
    public const string strconst="This is a\n \"string constant\" \\/\b\f \r＀ tabme\ttabme\n smile! 㷘Ǟ";
    public const int int32const=3856384;
    public static readonly int[] int32const_array={182476, 56483, -2947};
    public static readonly double[] doubleconst_array={1.5847, 3.14, -548e3, 3452.67e2, 485e-21};
    public static class structconst { public const string strconst="This is a\n \"string constant\" \\/\b\f \r＀ tabme\ttabme\n smile! 㷘Ǟ"; public static readonly int[] int32const_array={182476, 56483, -2947}; }
    public static class structconst2 { public static class structconst { public const string strconst="This is a\n \"string constant\" \\/\b\f \r＀ tabme\ttabme\n smile! 㷘Ǟ"; public static readonly int[] int32const_array={182476, 56483, -2947}; } public const int int32const=3856384; }
}
    public enum testenum1
    {
    value1 = 0
,
    value2 = 1
,
    value3 = 2
,
    anothervalue = -1
,
    anothervalue2 = -2
,
    anothervalue3 = -3
,
    hexval1 = 0x10
,
    hexval2 = 0x11
,
    neghexval1 = -2147483643
,
    neghexval2 = -2147483642
,
    more_values = -2147483641

    };
}