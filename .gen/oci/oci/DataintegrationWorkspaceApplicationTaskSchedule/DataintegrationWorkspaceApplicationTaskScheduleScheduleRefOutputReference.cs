using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceApplicationTaskScheduleScheduleRefOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceApplicationTaskScheduleScheduleRefOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceApplicationTaskScheduleScheduleRefOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceApplicationTaskScheduleScheduleRefOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFrequencyDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails\"}}]")]
        public virtual void PutFrequencyDetails(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata\"}}]")]
        public virtual void PutMetadata(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParentRef", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef\"}}]")]
        public virtual void PutParentRef(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrequencyDetails")]
        public virtual void ResetFrequencyDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentifier")]
        public virtual void ResetIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDaylightAdjustmentEnabled")]
        public virtual void ResetIsDaylightAdjustmentEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKey")]
        public virtual void ResetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelType")]
        public virtual void ResetModelType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelVersion")]
        public virtual void ResetModelVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStatus")]
        public virtual void ResetObjectStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectVersion")]
        public virtual void ResetObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentRef")]
        public virtual void ResetParentRef()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimezone")]
        public virtual void ResetTimezone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "frequencyDetails", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference FrequencyDetails
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataOutputReference Metadata
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRefOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRefOutputReference ParentRef
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRefOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frequencyDetailsInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails? FrequencyDetailsInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefFrequencyDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isDaylightAdjustmentEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDaylightAdjustmentEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata? MetadataInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStatusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ObjectStatusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ObjectVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentRefInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef? ParentRefInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefParentRef?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isDaylightAdjustmentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsDaylightAdjustmentEnabled
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

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectStatus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRef\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRef? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRef?>();
            set => SetInstanceProperty(value);
        }
    }
}
