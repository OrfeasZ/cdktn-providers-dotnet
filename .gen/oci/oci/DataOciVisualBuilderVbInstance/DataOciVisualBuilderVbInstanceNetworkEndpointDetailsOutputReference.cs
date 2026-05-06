using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciVisualBuilderVbInstance
{
    [JsiiClass(nativeType: typeof(oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsOutputReference), fullyQualifiedName: "oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciVisualBuilderVbInstanceNetworkEndpointDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciVisualBuilderVbInstanceNetworkEndpointDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciVisualBuilderVbInstanceNetworkEndpointDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciVisualBuilderVbInstanceNetworkEndpointDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowlistedHttpIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcnsList\"}")]
        public virtual oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcnsList AllowlistedHttpVcns
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcnsList>()!;
        }

        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkEndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciVisualBuilderVbInstance.DataOciVisualBuilderVbInstanceNetworkEndpointDetails\"}", isOptional: true)]
        public virtual oci.DataOciVisualBuilderVbInstance.IDataOciVisualBuilderVbInstanceNetworkEndpointDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciVisualBuilderVbInstance.IDataOciVisualBuilderVbInstanceNetworkEndpointDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
