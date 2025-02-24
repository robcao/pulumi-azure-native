# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ACLAction',
    'ManagedIdentityType',
    'UpstreamAuthType',
    'WebPubSubRequestType',
    'WebPubSubSkuTier',
]


class ACLAction(str, Enum):
    """
    Default action when no other rule matches
    """
    ALLOW = "Allow"
    DENY = "Deny"


class ManagedIdentityType(str, Enum):
    """
    Represent the identity type: systemAssigned, userAssigned, None
    """
    NONE = "None"
    SYSTEM_ASSIGNED = "SystemAssigned"
    USER_ASSIGNED = "UserAssigned"


class UpstreamAuthType(str, Enum):
    """
    Gets or sets the type of auth. None or ManagedIdentity is supported now.
    """
    NONE = "None"
    MANAGED_IDENTITY = "ManagedIdentity"


class WebPubSubRequestType(str, Enum):
    """
    Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.
    """
    CLIENT_CONNECTION = "ClientConnection"
    SERVER_CONNECTION = "ServerConnection"
    RESTAPI = "RESTAPI"
    TRACE = "Trace"


class WebPubSubSkuTier(str, Enum):
    """
    Optional tier of this particular SKU. 'Standard' or 'Free'. 
    
    `Basic` is deprecated, use `Standard` instead.
    """
    FREE = "Free"
    BASIC = "Basic"
    STANDARD = "Standard"
    PREMIUM = "Premium"
