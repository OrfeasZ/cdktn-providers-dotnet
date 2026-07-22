using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    [JsiiClass(nativeType: typeof(oci.CoreCrossConnect.CoreCrossConnectLoaPropertiesOutputReference), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectLoaPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreCrossConnectLoaPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreCrossConnectLoaPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreCrossConnectLoaPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreCrossConnectLoaPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuthorizedAgent")]
        public virtual void ResetAuthorizedAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiryExtensionCount")]
        public virtual void ResetExpiryExtensionCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizedAgentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizedAgentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiryExtensionCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpiryExtensionCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "authorizedAgent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizedAgent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expiryExtensionCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpiryExtensionCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectLoaProperties\"}", isOptional: true)]
        public virtual oci.CoreCrossConnect.ICoreCrossConnectLoaProperties? InternalValue
        {
            get => GetInstanceProperty<oci.CoreCrossConnect.ICoreCrossConnectLoaProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
