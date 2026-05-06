using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWlmsWlsDomain
{
    [JsiiClass(nativeType: typeof(oci.DataOciWlmsWlsDomain.DataOciWlmsWlsDomainConfigurationOutputReference), fullyQualifiedName: "oci.dataOciWlmsWlsDomain.DataOciWlmsWlsDomainConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWlmsWlsDomainConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWlmsWlsDomainConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWlmsWlsDomainConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWlmsWlsDomainConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminServerControlMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminServerControlMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminServerStartScriptPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminServerStartScriptPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminServerStopScriptPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminServerStopScriptPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPatchEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPatchEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRollbackOnFailure", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRollbackOnFailure
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managedServerControlMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedServerControlMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedServerStartScriptPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedServerStartScriptPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedServerStopScriptPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedServerStopScriptPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serversShutdownTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ServersShutdownTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWlmsWlsDomain.DataOciWlmsWlsDomainConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciWlmsWlsDomain.IDataOciWlmsWlsDomainConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWlmsWlsDomain.IDataOciWlmsWlsDomainConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
