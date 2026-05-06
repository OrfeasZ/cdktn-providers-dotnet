using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiClass(nativeType: typeof(oci.ContainerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequiredClaims", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequiredClaims(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCaCertificate")]
        public virtual void ResetCaCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientId")]
        public virtual void ResetClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationFile")]
        public virtual void ResetConfigurationFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupsClaim")]
        public virtual void ResetGroupsClaim()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupsPrefix")]
        public virtual void ResetGroupsPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuerUrl")]
        public virtual void ResetIssuerUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiredClaims")]
        public virtual void ResetRequiredClaims()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSigningAlgorithms")]
        public virtual void ResetSigningAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameClaim")]
        public virtual void ResetUsernameClaim()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernamePrefix")]
        public virtual void ResetUsernamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "requiredClaims", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaimsList\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaimsList RequiredClaims
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaimsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "caCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupsClaimInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupsClaimInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupsPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupsPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isOpenIdConnectAuthEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsOpenIdConnectAuthEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiredClaimsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequiredClaimsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signingAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SigningAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameClaimInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameClaimInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupsClaim
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupsPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isOpenIdConnectAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsOpenIdConnectAuthEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signingAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SigningAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsernameClaim
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsernamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig? InternalValue
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
