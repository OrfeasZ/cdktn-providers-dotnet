using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiClass(nativeType: typeof(oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsOutputReference), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreInstanceConfigurationInstanceDetailsSecondaryVnicsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreInstanceConfigurationInstanceDetailsSecondaryVnicsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreInstanceConfigurationInstanceDetailsSecondaryVnicsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstanceConfigurationInstanceDetailsSecondaryVnicsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCreateVnicDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails\"}}]")]
        public virtual void PutCreateVnicDetails(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreateVnicDetails")]
        public virtual void ResetCreateVnicDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNicIndex")]
        public virtual void ResetNicIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetailsOutputReference\"}")]
        public virtual oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetailsOutputReference CreateVnicDetails
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "createVnicDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails\"}", isOptional: true)]
        public virtual oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails? CreateVnicDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnicsCreateVnicDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nicIndexInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NicIndexInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nicIndex", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NicIndex
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsSecondaryVnics\"}]}}", isOptional: true)]
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
                        case oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnics cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsSecondaryVnics).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
