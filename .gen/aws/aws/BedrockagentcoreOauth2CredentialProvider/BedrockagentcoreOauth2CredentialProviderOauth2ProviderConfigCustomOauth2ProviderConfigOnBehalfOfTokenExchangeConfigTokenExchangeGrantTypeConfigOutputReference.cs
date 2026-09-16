using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfigOutputReference), fullyQualifiedName: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActorTokenScopes")]
        public virtual void ResetActorTokenScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "actorTokenContentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActorTokenContentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "actorTokenScopesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ActorTokenScopesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "actorTokenContent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActorTokenContent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "actorTokenScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ActorTokenScopes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
