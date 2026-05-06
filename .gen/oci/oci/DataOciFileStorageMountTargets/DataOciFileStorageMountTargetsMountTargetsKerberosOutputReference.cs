using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFileStorageMountTargets
{
    [JsiiClass(nativeType: typeof(oci.DataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsKerberosOutputReference), fullyQualifiedName: "oci.dataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsKerberosOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFileStorageMountTargetsMountTargetsKerberosOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFileStorageMountTargetsMountTargetsKerberosOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFileStorageMountTargetsMountTargetsKerberosOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFileStorageMountTargetsMountTargetsKerberosOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupKeyTabSecretVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currentKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentKeyTabSecretVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isKerberosEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsKerberosEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kerberosRealm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KerberosRealm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyTabSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyTabSecretId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFileStorageMountTargets.DataOciFileStorageMountTargetsMountTargetsKerberos\"}", isOptional: true)]
        public virtual oci.DataOciFileStorageMountTargets.IDataOciFileStorageMountTargetsMountTargetsKerberos? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFileStorageMountTargets.IDataOciFileStorageMountTargetsMountTargetsKerberos?>();
            set => SetInstanceProperty(value);
        }
    }
}
