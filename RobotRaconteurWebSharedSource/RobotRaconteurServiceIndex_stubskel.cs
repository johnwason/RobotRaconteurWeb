//This file is automatically generated. DO NOT EDIT!
using System;
using RobotRaconteurWeb;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RobotRaconteurWeb.Extensions;
namespace RobotRaconteurServiceIndex{

#pragma warning disable 1591

public class NodeInfo_stub : IStructureStub {
    public NodeInfo_stub(RobotRaconteurServiceIndexFactory d) {def=d;}
    private RobotRaconteurServiceIndexFactory def;
    public MessageElementNestedElementList PackStructure(Object s1) {
    List<MessageElement> m=new List<MessageElement>();
    if (s1 ==null) return null;
    NodeInfo s = (NodeInfo)s1;
    m.Add(new MessageElement("NodeName",s.NodeName));
    m.Add(new MessageElement("NodeID",s.NodeID));
    m.Add(new MessageElement("ServiceIndexConnectionURL",def.PackMapType<int,string>(s.ServiceIndexConnectionURL)));
    return new MessageElementNestedElementList(DataTypes.structure_t,"RobotRaconteurServiceIndex.NodeInfo",m);
    }
    public T UnpackStructure<T>(MessageElementNestedElementList m) {
    if (m == null ) return default(T);
    NodeInfo s=new NodeInfo();
    s.NodeName=MessageElement.FindElement(m.Elements,"NodeName").CastData<string>();
    s.NodeID=MessageElement.FindElement(m.Elements,"NodeID").CastData<byte[]>();
    s.ServiceIndexConnectionURL=(Dictionary<int,string>)def.UnpackMapType<int,string>(MessageElement.FindElement(m.Elements,"ServiceIndexConnectionURL").Data);
    T st; try {st=(T)((object)s);} catch (InvalidCastException e) {throw new DataTypeMismatchException("Wrong structuretype");}
    return st;
    }
}

public class ServiceInfo_stub : IStructureStub {
    public ServiceInfo_stub(RobotRaconteurServiceIndexFactory d) {def=d;}
    private RobotRaconteurServiceIndexFactory def;
    public MessageElementNestedElementList PackStructure(Object s1) {
    List<MessageElement> m=new List<MessageElement>();
    if (s1 ==null) return null;
    ServiceInfo s = (ServiceInfo)s1;
    m.Add(new MessageElement("Name",s.Name));
    m.Add(new MessageElement("RootObjectType",s.RootObjectType));
    m.Add(new MessageElement("RootObjectImplements",def.PackMapType<int,string>(s.RootObjectImplements)));
    m.Add(new MessageElement("ConnectionURL",def.PackMapType<int,string>(s.ConnectionURL)));
    m.Add(new MessageElement("Attributes",def.PackMapType<string,object>(s.Attributes)));
    return new MessageElementNestedElementList(DataTypes.structure_t, "RobotRaconteurServiceIndex.ServiceInfo",m);
    }
    public T UnpackStructure<T>(MessageElementNestedElementList m) {
    if (m == null ) return default(T);
    ServiceInfo s=new ServiceInfo();
    s.Name=MessageElement.FindElement(m.Elements,"Name").CastData<string>();
    s.RootObjectType=MessageElement.FindElement(m.Elements,"RootObjectType").CastData<string>();
    s.RootObjectImplements=(Dictionary<int,string>)def.UnpackMapType<int,string>(MessageElement.FindElement(m.Elements,"RootObjectImplements").Data);
    s.ConnectionURL=(Dictionary<int,string>)def.UnpackMapType<int,string>(MessageElement.FindElement(m.Elements,"ConnectionURL").Data);
    s.Attributes=(Dictionary<string,object>)def.UnpackMapType<string,object>(MessageElement.FindElement(m.Elements,"Attributes").Data);
    T st; try {st=(T)((object)s);} catch (InvalidCastException e) {throw new DataTypeMismatchException("Wrong structuretype");}
    return st;
    }
}

public class ServiceIndex_stub : ServiceStub , ServiceIndex {
    public ServiceIndex_stub(string path,ClientContext c) : base(path,c) {
    }

    public async Task<Dictionary<int,ServiceInfo>> GetLocalNodeServices(CancellationToken rr_cancel=default(CancellationToken)) {
    MessageEntry rr_mm=new MessageEntry(MessageEntryType.FunctionCallReq,"GetLocalNodeServices");
    MessageEntry rr_mr=await ProcessRequest(rr_mm,rr_cancel).ConfigureAwait(false);
    MessageElement rr_me = rr_mr.FindElement("return");
    return (Dictionary<int,ServiceInfo>)RRContext.UnpackMapType<int,ServiceInfo>(rr_me.Data);
    }
    public async Task<Dictionary<int,NodeInfo>> GetRoutedNodes(CancellationToken rr_cancel=default(CancellationToken)) {
    MessageEntry rr_mm=new MessageEntry(MessageEntryType.FunctionCallReq,"GetRoutedNodes");
    MessageEntry rr_mr=await ProcessRequest(rr_mm,rr_cancel).ConfigureAwait(false);
    MessageElement rr_me = rr_mr.FindElement("return");
    return (Dictionary<int,NodeInfo>)RRContext.UnpackMapType<int,NodeInfo>(rr_me.Data);
    }
    public async Task<Dictionary<int,NodeInfo>> GetDetectedNodes(CancellationToken rr_cancel=default(CancellationToken)) {
    MessageEntry rr_mm=new MessageEntry(MessageEntryType.FunctionCallReq,"GetDetectedNodes");
    MessageEntry rr_mr=await ProcessRequest(rr_mm,rr_cancel).ConfigureAwait(false);
    MessageElement rr_me = rr_mr.FindElement("return");
    return (Dictionary<int,NodeInfo>)RRContext.UnpackMapType<int,NodeInfo>(rr_me.Data);
    }

    public event Action LocalNodeServicesChanged;


    protected internal override void DispatchEvent(MessageEntry rr_m) {
    string rr_ename=rr_m.MemberName;
    switch (rr_ename) {
    case "LocalNodeServicesChanged": {
    if (LocalNodeServicesChanged!=null) {
    this.LocalNodeServicesChanged();
    }
    break;
    }
    }
    }
    protected internal override void DispatchPipeMessage(MessageEntry m)
    {
    switch (m.MemberName) {
    default:
    throw new Exception();
    }
    }
    protected internal override async Task<MessageEntry> CallbackCall(MessageEntry rr_m) {
    string rr_ename=rr_m.MemberName;
    MessageEntry rr_mr=new MessageEntry(MessageEntryType.CallbackCallRet, rr_ename);
    rr_mr.ServicePath=rr_m.ServicePath;
    rr_mr.RequestID=rr_m.RequestID;
    switch (rr_ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return rr_mr;
    }
    protected internal override void DispatchWireMessage(MessageEntry m)
    {
    switch (m.MemberName) {
    default:
    throw new Exception();
    }
    }

}
public class ServiceIndex_skel : ServiceSkel {
    ServiceIndex obj { get { return (ServiceIndex)uncastobj;}}
    public ServiceIndex_skel(string p,ServiceIndex o,ServerContext c) : base(p,o,c) {
    uncastobj=o;
    }
    public override async Task<MessageEntry> CallGetProperty(MessageEntry m) {
    string ename=m.MemberName;
    MessageEntry mr=new MessageEntry(MessageEntryType.PropertyGetRes, ename);
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return mr;
    }

    public override async Task<MessageEntry> CallSetProperty(MessageEntry m) {
    string ename=m.MemberName;
    MessageElement me=m.FindElement("value");
    MessageEntry mr=new MessageEntry(MessageEntryType.PropertySetRes, ename);
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return mr;
    }

    public override async Task<MessageEntry> CallFunction(MessageEntry rr_m) {
    string rr_ename=rr_m.MemberName;
    MessageEntry rr_mr=new MessageEntry(MessageEntryType.FunctionCallRes, rr_ename);
    switch (rr_ename) {
    case "GetLocalNodeServices": {
    object rr_ret=await obj.GetLocalNodeServices(default(CancellationToken)).ConfigureAwait(false);
    rr_mr.AddElement(new MessageElement("return",RRContext.PackMapType<int,ServiceInfo>(rr_ret)));
    break;
    }
    case "GetRoutedNodes": {
    object rr_ret=await obj.GetRoutedNodes(default(CancellationToken)).ConfigureAwait(false);
    rr_mr.AddElement(new MessageElement("return",RRContext.PackMapType<int,NodeInfo>(rr_ret)));
    break;
    }
    case "GetDetectedNodes": {
    object rr_ret=await obj.GetDetectedNodes(default(CancellationToken)).ConfigureAwait(false);
    rr_mr.AddElement(new MessageElement("return",RRContext.PackMapType<int,NodeInfo>(rr_ret)));
    break;
    }
    default:
    throw new MemberNotFoundException("Member not found");
    }
    return rr_mr;
    }
    public override void ReleaseCastObject() {}


    public void LocalNodeServicesChanged_Handler() {
    MessageEntry rr_mm=new MessageEntry(MessageEntryType.EventReq,"LocalNodeServicesChanged");
    this.SendEvent(rr_mm);
    }

    public override void RegisterEvents(Object obj1) {
    ServiceIndex obj = obj1 as ServiceIndex;
    obj.LocalNodeServicesChanged += LocalNodeServicesChanged_Handler;
    base.RegisterEvents(obj1);

    }
    public override void UnregisterEvents(Object obj1) {
    ServiceIndex obj = obj1 as ServiceIndex;
    obj.LocalNodeServicesChanged -= LocalNodeServicesChanged_Handler;
    base.UnregisterEvents(obj1);

    }

    public override async Task<Object> GetSubObj(string name, string ind) {
    switch (name) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    private bool rr_InitPipeServersRun=false;
    public override void InitPipeServers(object o) {
    if (this.rr_InitPipeServersRun) return;
    this.rr_InitPipeServersRun=true;
    ServiceIndex castobj=(ServiceIndex)o;
    }
    public override void DispatchPipeMessage(MessageEntry m, Endpoint e)
    {
    switch (m.MemberName) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override void DispatchWireMessage(MessageEntry m, Endpoint e)
    {
    switch (m.MemberName) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override void InitCallbackServers(object o) {
    ServiceIndex castobj=(ServiceIndex)o;
    }
    public override object GetCallbackFunction(uint endpoint,string membername) {
    switch(membername) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override async Task<MessageEntry> CallPipeFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override async Task<MessageEntry> CallWireFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
    public override async Task<MessageEntry> CallMemoryFunction(MessageEntry m,Endpoint e) {
    string ename=m.MemberName;
    switch (ename) {
    default:
    throw new MemberNotFoundException("Member not found");
    }
    }
}

}
