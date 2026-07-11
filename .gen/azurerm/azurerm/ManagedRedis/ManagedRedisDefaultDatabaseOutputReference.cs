using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedRedis.ManagedRedisDefaultDatabaseOutputReference), fullyQualifiedName: "azurerm.managedRedis.ManagedRedisDefaultDatabaseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedRedisDefaultDatabaseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedRedisDefaultDatabaseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedRedisDefaultDatabaseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedRedisDefaultDatabaseOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule" />)[]</param>
        [JsiiMethod(name: "putModule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabaseModule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessKeysAuthenticationEnabled")]
        public virtual void ResetAccessKeysAuthenticationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientProtocol")]
        public virtual void ResetClientProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusteringPolicy")]
        public virtual void ResetClusteringPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvictionPolicy")]
        public virtual void ResetEvictionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoReplicationGroupName")]
        public virtual void ResetGeoReplicationGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModule")]
        public virtual void ResetModule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersistenceAppendOnlyFileBackupFrequency")]
        public virtual void ResetPersistenceAppendOnlyFileBackupFrequency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersistenceRedisDatabaseBackupFrequency")]
        public virtual void ResetPersistenceRedisDatabaseBackupFrequency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "module", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabaseModuleList\"}")]
        public virtual azurerm.ManagedRedis.ManagedRedisDefaultDatabaseModuleList Module
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.ManagedRedisDefaultDatabaseModuleList>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "primaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessKeysAuthenticationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AccessKeysAuthenticationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusteringPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusteringPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "evictionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EvictionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoReplicationGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GeoReplicationGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "moduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabaseModule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "persistenceAppendOnlyFileBackupFrequencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersistenceAppendOnlyFileBackupFrequencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "persistenceRedisDatabaseBackupFrequencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersistenceRedisDatabaseBackupFrequencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "accessKeysAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AccessKeysAuthenticationEnabled
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

        [JsiiProperty(name: "clientProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusteringPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusteringPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvictionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "geoReplicationGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeoReplicationGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "persistenceAppendOnlyFileBackupFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersistenceAppendOnlyFileBackupFrequency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "persistenceRedisDatabaseBackupFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersistenceRedisDatabaseBackupFrequency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedRedis.ManagedRedisDefaultDatabase\"}", isOptional: true)]
        public virtual azurerm.ManagedRedis.IManagedRedisDefaultDatabase? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedRedis.IManagedRedisDefaultDatabase?>();
            set => SetInstanceProperty(value);
        }
    }
}
