using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiClass(nativeType: typeof(oci.DifStack.DifStackDataflowConnectionsOutputReference), fullyQualifiedName: "oci.difStack.DifStackDataflowConnectionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DifStackDataflowConnectionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DifStackDataflowConnectionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DifStackDataflowConnectionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DifStackDataflowConnectionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetails\"}}]")]
        public virtual void PutConnectionDetails(oci.DifStack.IDifStackDataflowConnectionsConnectionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DifStack.IDifStackDataflowConnectionsConnectionDetails)}, new object[]{@value});
        }

        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetailsOutputReference\"}")]
        public virtual oci.DifStack.DifStackDataflowConnectionsConnectionDetailsOutputReference ConnectionDetails
        {
            get => GetInstanceProperty<oci.DifStack.DifStackDataflowConnectionsConnectionDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionDetailsInput", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetails\"}", isOptional: true)]
        public virtual oci.DifStack.IDifStackDataflowConnectionsConnectionDetails? ConnectionDetailsInput
        {
            get => GetInstanceProperty<oci.DifStack.IDifStackDataflowConnectionsConnectionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnections\"}", isOptional: true)]
        public virtual oci.DifStack.IDifStackDataflowConnections? InternalValue
        {
            get => GetInstanceProperty<oci.DifStack.IDifStackDataflowConnections?>();
            set => SetInstanceProperty(value);
        }
    }
}
