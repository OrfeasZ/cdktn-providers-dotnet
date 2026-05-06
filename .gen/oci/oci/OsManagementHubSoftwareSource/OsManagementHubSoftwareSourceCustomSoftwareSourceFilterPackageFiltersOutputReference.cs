using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSource
{
    [JsiiClass(nativeType: typeof(oci.OsManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersOutputReference), fullyQualifiedName: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFiltersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilterType")]
        public virtual void ResetFilterType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageName")]
        public virtual void ResetPackageName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageNamePattern")]
        public virtual void ResetPackageNamePattern()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageVersion")]
        public virtual void ResetPackageVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FilterTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageNamePatternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageNamePatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilterType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageNamePattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageNamePattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters\"}]}}", isOptional: true)]
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
                        case oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
