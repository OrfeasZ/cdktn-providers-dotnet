using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    [JsiiClass(nativeType: typeof(azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfileOutputReference), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RedhatOpenshiftClusterPlatformWorkloadIdentityProfileOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RedhatOpenshiftClusterPlatformWorkloadIdentityProfileOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RedhatOpenshiftClusterPlatformWorkloadIdentityProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedhatOpenshiftClusterPlatformWorkloadIdentityProfileOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity" />)[]</param>
        [JsiiMethod(name: "putPlatformWorkloadIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPlatformWorkloadIdentity(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetUpgradeableTo")]
        public virtual void ResetUpgradeableTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "platformWorkloadIdentity", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentityList\"}")]
        public virtual azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentityList PlatformWorkloadIdentity
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentityList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "platformWorkloadIdentityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfilePlatformWorkloadIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PlatformWorkloadIdentityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeableToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeableToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "upgradeableTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeableTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterPlatformWorkloadIdentityProfile\"}", isOptional: true)]
        public virtual azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterPlatformWorkloadIdentityProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
