using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IamSaml
{
    [JsiiClass(nativeType: typeof(scaleway.IamSaml.IamSamlServiceProviderOutputReference), fullyQualifiedName: "scaleway.iamSaml.IamSamlServiceProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IamSamlServiceProviderOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IamSamlServiceProviderOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IamSamlServiceProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IamSamlServiceProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assertionConsumerServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssertionConsumerServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.iamSaml.IamSamlServiceProvider\"}", isOptional: true)]
        public virtual scaleway.IamSaml.IIamSamlServiceProvider? InternalValue
        {
            get => GetInstanceProperty<scaleway.IamSaml.IIamSamlServiceProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
