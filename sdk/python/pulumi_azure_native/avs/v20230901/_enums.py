# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'AddonType',
    'AvailabilityStrategy',
    'DhcpTypeEnum',
    'DnsServiceLogLevelEnum',
    'DnsZoneType',
    'EncryptionState',
    'InternetEnum',
    'MountOptionEnum',
    'PlacementPolicyState',
    'PlacementPolicyType',
    'PortMirroringDirectionEnum',
    'ScriptExecutionParameterType',
    'SkuTier',
    'SslEnum',
    'SystemAssignedServiceIdentityType',
]


class AddonType(str, Enum):
    """
    Addon type
    """
    SRM = "SRM"
    VR = "VR"
    HCX = "HCX"
    ARC = "Arc"


class AvailabilityStrategy(str, Enum):
    """
    The availability strategy for the private cloud
    """
    SINGLE_ZONE = "SingleZone"
    """
    in single zone
    """
    DUAL_ZONE = "DualZone"
    """
    in two zones
    """


class DhcpTypeEnum(str, Enum):
    """
    Type of DHCP: SERVER or RELAY.
    """
    SERVER = "SERVER"
    RELAY = "RELAY"


class DnsServiceLogLevelEnum(str, Enum):
    """
    DNS Service log level.
    """
    DEBUG = "DEBUG"
    """
    is debug
    """
    INFO = "INFO"
    """
    is info
    """
    WARNING = "WARNING"
    """
    is warning
    """
    ERROR = "ERROR"
    """
    is error
    """
    FATAL = "FATAL"
    """
    is fatal
    """


class DnsZoneType(str, Enum):
    """
    The type of DNS zone to use.
    """
    PUBLIC = "Public"
    """
    Primary DNS zone.
    """
    PRIVATE = "Private"
    """
    Private DNS zone.
    """


class EncryptionState(str, Enum):
    """
    Status of customer managed encryption key
    """
    ENABLED = "Enabled"
    """
    is enabled
    """
    DISABLED = "Disabled"
    """
    is disabled
    """


class InternetEnum(str, Enum):
    """
    Connectivity to internet is enabled or disabled
    """
    ENABLED = "Enabled"
    """
    is enabled
    """
    DISABLED = "Disabled"
    """
    is disabled
    """


class MountOptionEnum(str, Enum):
    """
    Mode that describes whether the LUN has to be mounted as a datastore or
    attached as a LUN
    """
    MOUNT = "MOUNT"
    """
    is mount
    """
    ATTACH = "ATTACH"
    """
    is attach
    """


class PlacementPolicyState(str, Enum):
    """
    Whether the placement policy is enabled or disabled
    """
    ENABLED = "Enabled"
    """
    is enabled
    """
    DISABLED = "Disabled"
    """
    is disabled
    """


class PlacementPolicyType(str, Enum):
    """
    Placement Policy type
    """
    VM_VM = "VmVm"
    VM_HOST = "VmHost"


class PortMirroringDirectionEnum(str, Enum):
    """
    Direction of port mirroring profile.
    """
    INGRESS = "INGRESS"
    """
    is ingress
    """
    EGRESS = "EGRESS"
    """
    is egress
    """
    BIDIRECTIONAL = "BIDIRECTIONAL"
    """
    is bidirectional
    """


class ScriptExecutionParameterType(str, Enum):
    """
    script execution parameter type
    """
    VALUE = "Value"
    SECURE_VALUE = "SecureValue"
    CREDENTIAL = "Credential"


class SkuTier(str, Enum):
    """
    This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
    """
    FREE = "Free"
    BASIC = "Basic"
    STANDARD = "Standard"
    PREMIUM = "Premium"


class SslEnum(str, Enum):
    """
    Protect LDAP communication using SSL certificate (LDAPS)
    """
    ENABLED = "Enabled"
    """
    is enabled
    """
    DISABLED = "Disabled"
    """
    is disabled
    """


class SystemAssignedServiceIdentityType(str, Enum):
    """
    Type of managed service identity (either system assigned, or none).
    """
    NONE = "None"
    SYSTEM_ASSIGNED = "SystemAssigned"
