using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolAzureDevopsOrganizationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolAzureDevopsOrganizationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDevopsPoolAzureDevopsOrganizationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolAzureDevopsOrganizationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization" />)[]</param>
        [JsiiMethod(name: "putOrganization", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOrganization(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPermission", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission\"}}]")]
        public virtual void PutPermission(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPermission")]
        public virtual void ResetPermission()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "organization", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganizationList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganizationList Organization
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganizationList>()!;
        }

        [JsiiProperty(name: "permission", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference Permission
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "organizationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrganizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission? PermissionInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganization\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization?>();
            set => SetInstanceProperty(value);
        }
    }
}
