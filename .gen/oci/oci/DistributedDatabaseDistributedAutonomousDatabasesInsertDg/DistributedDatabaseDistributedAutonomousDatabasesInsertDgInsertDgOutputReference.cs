using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg
{
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgOutputReference), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase\"}}]")]
        public virtual void PutDatabase(oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase)}, new object[]{@value});
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference Database
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase? DatabaseInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicaNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SelectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicaName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Selection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg\"}]}}", isOptional: true)]
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
                        case oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
