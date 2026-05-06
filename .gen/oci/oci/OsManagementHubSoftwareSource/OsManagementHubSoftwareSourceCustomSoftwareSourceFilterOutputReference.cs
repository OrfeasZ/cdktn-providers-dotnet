using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSource
{
    [JsiiClass(nativeType: typeof(oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterOutputReference), fullyQualifiedName: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OsManagementHubSoftwareSourceCustomSoftwareSourceFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OsManagementHubSoftwareSourceCustomSoftwareSourceFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OsManagementHubSoftwareSourceCustomSoftwareSourceFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubSoftwareSourceCustomSoftwareSourceFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putModuleStreamProfileFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModuleStreamProfileFilters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPackageFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPackageFilters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPackageGroupFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFilters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPackageGroupFilters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFilters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFilters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFilters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetModuleStreamProfileFilters")]
        public virtual void ResetModuleStreamProfileFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageFilters")]
        public virtual void ResetPackageFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageGroupFilters")]
        public virtual void ResetPackageGroupFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "moduleStreamProfileFilters", typeJson: "{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFiltersList\"}")]
        public virtual oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFiltersList ModuleStreamProfileFilters
        {
            get => GetInstanceProperty<oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFiltersList>()!;
        }

        [JsiiProperty(name: "packageFilters", typeJson: "{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersList\"}")]
        public virtual oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersList PackageFilters
        {
            get => GetInstanceProperty<oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersList>()!;
        }

        [JsiiProperty(name: "packageGroupFilters", typeJson: "{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFiltersList\"}")]
        public virtual oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFiltersList PackageGroupFilters
        {
            get => GetInstanceProperty<oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFiltersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "moduleStreamProfileFiltersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModuleStreamProfileFiltersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageFiltersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PackageFiltersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageGroupFiltersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PackageGroupFiltersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilter\"}", isOptional: true)]
        public virtual oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilter? InternalValue
        {
            get => GetInstanceProperty<oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
