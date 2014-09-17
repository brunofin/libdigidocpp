/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace digidoc {

using System;
using System.Runtime.InteropServices;

public class Document : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Document(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Document obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Document() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          digidocPINVOKE.delete_Document(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public Document(string filepath, string mediaType) : this(digidocPINVOKE.new_Document__SWIG_0(filepath, mediaType), true) {
    if (digidocPINVOKE.SWIGPendingException.Pending) throw digidocPINVOKE.SWIGPendingException.Retrieve();
  }

  public Document(string filename, string filepath, string mediaType) : this(digidocPINVOKE.new_Document__SWIG_1(filename, filepath, mediaType), true) {
    if (digidocPINVOKE.SWIGPendingException.Pending) throw digidocPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getFileName() {
    string ret = digidocPINVOKE.Document_getFileName(swigCPtr);
    return ret;
  }

  public string getFilePath() {
    string ret = digidocPINVOKE.Document_getFilePath(swigCPtr);
    return ret;
  }

  public string getMediaType() {
    string ret = digidocPINVOKE.Document_getMediaType(swigCPtr);
    return ret;
  }

  public uint getSize() {
    uint ret = digidocPINVOKE.Document_getSize(swigCPtr);
    if (digidocPINVOKE.SWIGPendingException.Pending) throw digidocPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte[] calcDigest(SWIGTYPE_p_digidoc__Digest calc) {
  IntPtr data = digidocPINVOKE.Document_calcDigest(swigCPtr, SWIGTYPE_p_digidoc__Digest.getCPtr(calc));
  byte[] result = new byte[digidocPINVOKE.ByteVector_size(data)];
  Marshal.Copy(digidocPINVOKE.ByteVector_data(data), result, 0, result.Length);
  return result;
}

  public void saveAs(string path) {
    digidocPINVOKE.Document_saveAs(swigCPtr, path);
    if (digidocPINVOKE.SWIGPendingException.Pending) throw digidocPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
