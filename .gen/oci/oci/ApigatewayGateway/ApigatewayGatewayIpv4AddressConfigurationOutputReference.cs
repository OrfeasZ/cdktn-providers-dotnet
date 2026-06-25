using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayGateway
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayGateway.ApigatewayGatewayIpv4AddressConfigurationOutputReference), fullyQualifiedName: "oci.apigatewayGateway.ApigatewayGatewayIpv4AddressConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApigatewayGatewayIpv4AddressConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApigatewayGatewayIpv4AddressConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApigatewayGatewayIpv4AddressConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayGatewayIpv4AddressConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetReservedIpIds")]
        public virtual void ResetReservedIpIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservedIpIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ReservedIpIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "reservedIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReservedIpIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apigatewayGateway.ApigatewayGatewayIpv4AddressConfiguration\"}", isOptional: true)]
        public virtual oci.ApigatewayGateway.IApigatewayGatewayIpv4AddressConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.ApigatewayGateway.IApigatewayGatewayIpv4AddressConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
